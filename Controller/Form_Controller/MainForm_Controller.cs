using Controller.Data;
using Library.Entity;
using Library.Servser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Form_Controller
{
    public class MainForm_Controller
    {
        private static MainForm_Controller instance;
        public static MainForm_Controller Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainForm_Controller();
                }
                return instance;
            }
        }
        public MainForm_Controller() 
        {
        }
    }
}
