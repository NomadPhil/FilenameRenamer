using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FileHelpers;

namespace AudioRenamer
{
    public partial class Form1 : Form
    {
        private const string MappingCsvFileDefault = @"D:\\Audios\Maps\DestinationMappings.csv";
        private const string ImportDirectoryDefault = @"D:\\Audios";
        private const string ExportDirectoryDefault = @"D:\\Audios\RenamedAudios\Destinations";
        private const string ExtensionDefault = @"wav";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string mappingCsvFileDefault = txtMappingCsvFile.Text;
            string importDirectory = txtImportDirectory.Text;
            string exportDirectory = txtExportDirectory.Text;
            string extension = txtExtension.Text;

            bool hasErrors = false;

            if (string.IsNullOrWhiteSpace(mappingCsvFileDefault))
            {
                errorProvider1.SetError(txtMappingCsvFile, "Mapping CSV File required!");
                hasErrors = true;
            }
            if (!File.Exists(mappingCsvFileDefault))
            {
                errorProvider1.SetError(txtMappingCsvFile, "CSV File does not exist!");
                hasErrors = true;
            }

            if (string.IsNullOrWhiteSpace(importDirectory))
            {
                errorProvider1.SetError(txtImportDirectory, "Import directory required!");
                hasErrors = true;
            }
            else if (!Directory.Exists(importDirectory))
            {
                errorProvider1.SetError(txtImportDirectory, "Import directory does not exist!");
                hasErrors = true;
            }

            if (string.IsNullOrWhiteSpace(exportDirectory))
            {
                errorProvider1.SetError(txtExportDirectory, "Export directory required!");
                hasErrors = true;
            }

            if (string.IsNullOrWhiteSpace(extension))
            {
                errorProvider1.SetError(txtExtension, "File extension type required!");
                hasErrors = true;
            }
            else if (extension.Substring(0) != ".")
            {
                extension = "." + extension;
            }

            if (hasErrors)
                return;

            if (!Directory.Exists(exportDirectory))
            {
                Directory.CreateDirectory(exportDirectory);
            }

            // Import audio mappings
            var engine = new FileHelperEngine<AudioMapping>();

            engine.ErrorManager.ErrorMode = ErrorMode.SaveAndContinue;

            var importRecords = engine.ReadFile(mappingCsvFileDefault).ToList();

            int filesCopied = 0;
            int missingFiles = 0;
            var missingFilesNames = new List<string>();

            foreach (var mapping in importRecords)
            {
                string originalFileName = mapping.OriginalFileName.Trim();

                if (!originalFileName.EndsWith(extension))
                {
                    originalFileName = originalFileName + extension;
                }

                string newFileName = mapping.NewFileName.Trim();

                if (!newFileName.EndsWith(extension))
                {
                    newFileName = newFileName +  "_" + originalFileName;
                }

                string originalFilePath = Path.Combine(importDirectory, originalFileName);

                if (File.Exists(originalFilePath))
                {

                    string newFilePath = Path.Combine(exportDirectory, newFileName);

                    File.Copy(originalFilePath, newFilePath, true);

                    filesCopied++;
                }
                else
                {
                    missingFiles++;

                    missingFilesNames.Add(originalFileName);
                }

            }

            var messageBuilder = new StringBuilder();

            messageBuilder.AppendLine(string.Format("Copied files: {0}, Missing files {1}", filesCopied, missingFiles));

            foreach (var file in missingFilesNames)
            {
                messageBuilder.AppendLine(file);
            }

            MessageBox.Show(messageBuilder.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMappingCsvFile.Text = MappingCsvFileDefault;
            txtImportDirectory.Text = ImportDirectoryDefault;
            txtExportDirectory.Text = ExportDirectoryDefault;
            txtExtension.Text = ExtensionDefault;
        }
    }
}
