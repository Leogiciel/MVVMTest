using IModels;

namespace ViewModels
{
    public class ViewModel
    {
        private IModel _Model { get; set; }

        private string name;

        public string Name
        {
            //Load if null
            get { return name ?? (name = _Model.Name); }
            private set { name = value; }
        }

        public ViewModel()
        {
            //Call generic DAO builder
            _Model = DAOBuilder.Builder.GetDAO();
        }

        public void Validate()
        {
            //Validation and save to persistance
            if (string.IsNullOrWhiteSpace(name)) _Model.Name = name;
        }
    }
}
