using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Administrator
{
    public static class Notification
    {

        public static void CantEstablishConnection()
        {
            ShowNotificationFrame("Критическая ошибка",
                                  "Невозможно установить соединение или обновить базу данных. Приложение будет закрыто.",
                                  MessageBoxIcon.Stop);
        }

        public static void NeedEnterBlackListReason()
        {
            ShowNotificationFrame("Внимание",
                                  "Необходимо ввести причину занесения в \"чёрный\" список.",
                                  MessageBoxIcon.Warning);
        }

        private static void ShowNotificationFrame(string caption, string text, MessageBoxIcon icon)
        {
            XtraMessageBox.Show(text, caption, MessageBoxButtons.OK, icon);
        }
    }
}