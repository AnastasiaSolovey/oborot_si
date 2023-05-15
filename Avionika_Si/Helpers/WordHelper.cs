using Avionika_Si.Models;
using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;
using DocumentFormat.OpenXml.Packaging;

namespace Avionika_Si.Helpers
{
    internal class WordHelper
    {
        private static readonly string outputDir = $"{Environment.CurrentDirectory}\\Output";
        private static readonly string templateDir = $"{Environment.CurrentDirectory}\\DocumentTemplates";
        private static bool CopyAndCheckFile(string basePath, string outPath)
        {

            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }

            if (File.Exists(basePath))
            {
                File.Copy(basePath, outPath);
            }
            else
            {
                return false;
            }

            if (!File.Exists(outPath))
            {
                MessageBox.Show("Ошибка при копировании основного файла шаблона");
                return false;
            }

            return true;
        }

        public static void CreateCertificateDoc(Certificate certificate)
        {

            string templatePath = $"{templateDir}\\calibration_cert_template.docx";
            string outputPath = $"{outputDir}\\{certificate.MeasuringInstrumentName}_{certificate.ProtocolNumber}_{DateTime.Now.ToString("dd_MM_yyy_HH_mm_ss")}.docx";
            if (File.Exists(templatePath))
            {
                if (CopyAndCheckFile(templatePath, outputPath))
                {
                    Word.Application wordApp = new Word.Application();
                    wordApp.Visible = false;

                    Word.Document wordDoc = wordApp.Documents.Open(outputPath);
                    UpdateCustomPropertiesToWordDocument(wordDoc, certificate.GetCertificatePropsDictionartForWord());

                    wordDoc.Save();

                    wordApp.Visible = true;
                }
                else
                {
                    MessageBox.Show("Ошибка при создании файла на основе шаблона");
                }
            }
        }

        private static void UpdateCustomPropertiesToWordDocument(Word.Document doc, Dictionary<string, string> propsValues)
        {
            foreach (var property in propsValues)
            {
                try
                {
                    doc.CustomDocumentProperties[property.Key] = property.Value;
                }
                catch
                {
                    continue;
                }
            }

            foreach (var field in doc.Fields.Cast<Word.Field>())
            {
                field.Update();
            }

        }
            /*public static void CreateCertificateDoc(Certificate certificate)
            {
                string templatePath = $"{templateDir}\\calibration_cert_template.docx";
                string outputPath = $"{outputDir}\\{certificate.MeasuringInstrumentName}_{certificate.ProtocolNumber}_{DateTime.Now.ToString("dd_MM_yyy_HH_mm_ss")}.docx";
                if (File.Exists(templatePath))
                {
                    if (CopyAndCheckFile(templatePath, outputPath))
                    {
                        using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(outputPath, true))
                        {
                            var documentProperties = wordDoc.CustomFilePropertiesPart.Properties;
                            var prop = documentProperties.Where(p => ((CustomDocumentProperty)p).Name.Value == "MesInstrName").FirstOrDefault();

                            AddCustomPropertiesToWordDocument(wordDoc, certificate.GetCertificatePropsDictionartForWord());



                            DocumentSettingsPart settingsPart = wordDoc.MainDocumentPart.GetPartsOfType<DocumentSettingsPart>().First();
                            UpdateFieldsOnOpen updateFields = new UpdateFieldsOnOpen();
                            updateFields.Val = new OnOffValue(true);
                            settingsPart.Settings.PrependChild<UpdateFieldsOnOpen>(updateFields);
                            settingsPart.Settings.Save();
                            wordDoc.MainDocumentPart.Document.Save();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при создании файла на основе шаблона");
                    }
                }
            }

            private static void AddCustomPropertiesToWordDocument(WordprocessingDocument doc, Dictionary<string, string> propsValues)
            {
                // Add a main document part.
                MainDocumentPart mainPart = doc.MainDocumentPart;

                //CustomFilePropertiesPart
                CustomFilePropertiesPart customProps = doc.CustomFilePropertiesPart;

                //add part if it doesn't exist
                if (customProps == null)
                {
                    customProps = doc.AddCustomFilePropertiesPart();
                    customProps.Properties = new DocumentFormat.OpenXml.CustomProperties.Properties();
                }



                DocumentFormat.OpenXml.CustomProperties.Properties props = customProps.Properties;

                foreach(var property in propsValues)
                {
                    //check if property already exists
                    var prop = props.Where(p => ((CustomDocumentProperty)p).Name.Value == property.Key).FirstOrDefault();

                    //remove property, if it exists
                    string currentPropValue;
                    if (prop != null)
                    {
                        currentPropValue = prop.InnerText;
                        prop.Remove();
                    }

                    //create custom property
                    CustomDocumentProperty customProp = new CustomDocumentProperty();
                    customProp.Name = property.Key;
                    customProp.VTLPWSTR = new VTLPWSTR(property.Value);
                    customProp.FormatId = "{D5CDD505-2E9C-101B-9397-08002B2CF9AE}";

                    // Append the new property, and 
                    // fix up all the property ID values. 
                    // The PropertyId value must start at 2.
                    props.AppendChild(customProp);
                    int pid = 2;
                    foreach (CustomDocumentProperty item in props)
                    {
                        item.PropertyId = pid++; //increment
                    }

                }

                props.Save();
            }

        }*/
    }
}
