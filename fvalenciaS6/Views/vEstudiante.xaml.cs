using Newtonsoft.Json;                   
using fvalenciaS6.Models;
using System.Collections.ObjectModel;   //Se agrego esta libreria       3

namespace fvalenciaS6.Views;
												//Controlador de la vista vEstudiante
public partial class vEstudiante : ContentPage   
{   
	private const string url = "http://192.168.56.1/Moviles/wsestudiantes.php"; 
	private readonly HttpClient cliente = new HttpClient(); 
	private ObservableCollection<Estudiante> est;  

    public vEstudiante()							
	{

        InitializeComponent();
        ObtenerDatos();  
    }


    public async void ObtenerDatos() 
	{
		var content = await cliente.GetStringAsync(url); 
		List<Estudiante> mostrar =	JsonConvert.DeserializeObject<List<Estudiante>>(content);
		est = new ObservableCollection<Estudiante>(mostrar);
		ListEstudiante.ItemsSource = est; 

    }
}