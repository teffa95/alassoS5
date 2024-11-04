using alassoS5.Utils;

namespace alassoS5
{
    public partial class App : Application

        {
            public static PersonRepository PersonRepo { get; set; }
            public App(PersonRepository personRepository)
            {
                InitializeComponent();

                MainPage = new Views.Principal();
                PersonRepo = personRepository;
            }
        }
}