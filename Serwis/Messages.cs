namespace Serwis
{
    public class Messages
    {
        // General messages
        public const string NoPosition = "Proszę wybrać pozycje";
        public const string SaveChanges = "Czy chcesz zapisać zmiany ?";
        public const string ChangesSaved = "Zmiany zostały zapisane";
        public const string Attention = "Uwaga";
        public const string Yes = "Tak";
        public const string No = "Nie";

        // MainForm messages
        public const string MainForm_NoDeviceType = "Proszę wybrać typ urządzenia";

        // RepairAddEditForm messages
        public const string RepairAddEditForm_NoPositionType = "Proszę wybrać typ pozycji";
        public const string RepairAddEditForm_NoPosition = "Proszę wybrać pozycję";
        public const string RepairAddEditForm_EmptyPositionFields = "Proszę wypełnić wszystkie pola pozycji";
        public const string RepairAddEditForm_NoClient = "Proszę wybrać klienta";
        public const string RepairAddEditForm_NoDevice = "Proszę wybrać urządzenie";
        public const string RepairAddEditForm_EditFormText = "Edytuj zlecenie";

        // ClientEditForm messages
        public const string ClientEditForm_EmptyName = "Pole imię i nazwisko nie może być puste";
        public const string ClientEditForm_IncorrectEmail = "Nieprawidłowy adres e-mail";
        
        // DeviceEditForm messages
        public const string DeviceEditForm_EmptyName = "Pole nazwa urządzenia nie może być puste";

        // RepairsManagement messages
        public const string RepairsManagement_RepairClosed = "Wybrane zlecenie zostało już zamknięte";

        // ClientsManagement messages
        public const string ClientsManagement_ClientHaveHistory = "Nie można usunąć klienta ponieważ posiada przypisane zlecenia";
        public const string ClientManagement_EmptyName = "Pole imię i nazwisko nie może być puste";
        public const string ClientManagement_IncorrectEmail = "Nieprawidłowy adres e-mail";

        // DevicesManagement messages
        public const string DevicesManagement_DeviceHaveHistory = "Nie można usunąć urządzenia ponieważ posiada przypisane zlecenia";
        public const string DevicesManagement_EmptyName = "Pole nazwa urządzenia nie może być puste";

        // InfoForm
        public const string InfoForm_Info = "Aplikcja została wykonana z użyciem Metro UI Framework for .NET WinForms (http://denricdenise.info/)";

    }
}
