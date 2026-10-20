using System.Text;

namespace BaobabRidgeWildlifeSystem
{
    public static class ExceptionHandler
    {
        private const string LogFileName = "errors.log";
        private static readonly object LogLock = new object();

        // handles an exception: log it, then tell the user
        public static void Handle(Exception ex, string context = "", bool showMessage = true)
        {
            try
            {
                if (ex == null)
                    return;

                LogException(ex, context);

                if (showMessage)
                    ShowMessage(ex, context);
            }
            catch
            {
                // handler itself must never crash the application
            }
        }

        // decides the title, message and icon for each kind of exception
        private static void ShowMessage(Exception ex, string context)
        {
            string title;
            string message;
            MessageBoxIcon icon = MessageBoxIcon.Error;

            switch (ex)
            {
                case FileNotFoundException fileNotFound:
                    title = "File Not Found";
                    message = fileNotFound.Message;
                    break;

                case DirectoryNotFoundException:
                    title = "Folder Not Found";
                    message = "The folder that holds the animal records could not be found.\n\n" + ex.Message;
                    break;

                case UnauthorizedAccessException:
                    title = "Permission Error";
                    message = "Access to the animal records file was denied.\n\n" +
                              "Check that the file is not read-only and that you have permission to use this folder.";
                    break;

                case InvalidDataException:
                    title = "Invalid Data";
                    message = ex.Message;
                    icon = MessageBoxIcon.Warning;
                    break;

                case IOException:
                    title = "File Error";
                    message = "A file error occurred while reading or writing the animal records.\n\n" + ex.Message +"\n\nMake sure the file is not open in another program and try again.";
                    break;

                case FormatException:
                case OverflowException:
                    title = "Invalid Input";
                    message = "A value was not in the correct format.\n\n" + ex.Message;
                    icon = MessageBoxIcon.Warning;
                    break;

                case ArgumentOutOfRangeException:
                case ArgumentException:
                    title = "Invalid Value";
                    message = ex.Message;
                    icon = MessageBoxIcon.Warning;
                    break;

                case InvalidOperationException:
                    title = "Operation Error";
                    message = "That action could not be completed.\n\n" + ex.Message;
                    break;

                default:
                    title = "Unexpected Error";
                    message = "Something went wrong.\n\n" + ex.Message;
                    break;
            }

            if (!string.IsNullOrWhiteSpace(context))
                message = $"{context}\n\n{message}";

            message += $"\n\nDetails were saved to {LogFileName}.";

            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        // writes the exception details to errors.log
        private static void LogException(Exception ex, string context)
        {
            try
            {
                var entry = new StringBuilder();
                entry.AppendLine("==================================================");
                entry.AppendLine($"Time:    {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                entry.AppendLine($"Context: {(string.IsNullOrWhiteSpace(context) ? "(none)" : context)}");
                entry.AppendLine($"Type:    {ex.GetType().FullName}");
                entry.AppendLine($"Message: {ex.Message}");
                entry.AppendLine("Stack trace:");
                entry.AppendLine(ex.StackTrace ?? "(none)");

                if (ex.InnerException != null)
                {
                    entry.AppendLine($"Inner exception: {ex.InnerException.GetType().FullName}: {ex.InnerException.Message}");
                }

                string logPath = Path.Combine(AppContext.BaseDirectory, LogFileName);

                lock (LogLock)
                {
                    File.AppendAllText(logPath, entry.ToString());
                }
            }
            catch
            {
                // if logging fails, still show the message
            }
        }
    }
}
