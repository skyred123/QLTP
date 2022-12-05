namespace Controller.UserControls_Controller
{
    public class UC_TTNV_Controller
    {
        private static UC_TTNV_Controller instance;
        public static UC_TTNV_Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UC_TTNV_Controller();
                }
                return instance;
            }
        }
        public UC_TTNV_Controller() { }
    }
}
