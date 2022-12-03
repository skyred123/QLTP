namespace Controller.UserControls_Controller
{
    public class UC_TTNhanVien_Controller
    {
        private static UC_TTNhanVien_Controller instance;
        public static UC_TTNhanVien_Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UC_TTNhanVien_Controller();
                }
                return instance;
            }
        }
        public UC_TTNhanVien_Controller() { }
    }
}
