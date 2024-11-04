using alassoS5.Models;

namespace alassoS5.Views;

public partial class Principal : ContentPage
{
    private readonly object statusMessage;

    public Principal()
    {
        InitializeComponent();
        LoadPersonas();

    }
    private void LoadPersonas()
    {
        lblStatus.Text = "";
        List<Persona> people = App.PersonRepo.GetAllPeople();
        listaPersona.ItemsSource = people;
    }
    private void btnObtener_Clicked(object sender, EventArgs e)
    {
        lblStatus.Text = $"Total de personas: {App.PersonRepo.GetAllPeople().Count}";

    }

    public void btnAgregar_Clicked(object sender, EventArgs e)
    {
        App.PersonRepo.AddPerson(new Persona { Nombre = txtNombre.Text });
        txtNombre.Text = "";
        LoadPersonas();

    }
     
    private void btnMostar_Clicked(object sender, EventArgs e)
    {

    }

    private void btnActualizar_Clicked(object sender, EventArgs e)
    {
        var persona = (Persona)listaPersona.SelectedItem;
        persona.Nombre = txtNombre.Text;
        App.PersonRepo.UpdatePerson(persona);
        txtNombre.Text = "";
        LoadPersonas();
    }

    private void btnEliminar_Clicked(object sender, EventArgs e)
    {
        var persona = (Persona)listaPersona.SelectedItem;
        App.PersonRepo.DeletePerson(persona);
        LoadPersonas();
    }
}