namespace fvalenciaS6
{           //PARECE QUE ESTE ES EL CODIGO PRINCIPAL PARA EJECUTAR
    public partial class App : Application //Esto hicimos al ultimo porque nos olvidados de poner
    {   
        public App()  
        {
            InitializeComponent();

            MainPage = new Views.vEstudiante();//ESTO TIENE QUE EJECUTARSE PRIMERO, PORQUE ESA ES LA VISDTA QUE NECESITAS
            //MainPage = new AppShell(); // Este es la primera vista cuando creas un proyecto
        }
    }
}
