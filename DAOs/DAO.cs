using IModels;

namespace DAOs
{
    public class DAO : IModel
    {
        public string Name
        {
            get
            {
                //Load from db
                Properties.Settings.Default.Reload();
                return Properties.Settings.Default.Name;
            }
            set
            {
                //Save to db
                Properties.Settings.Default.Name = value;
                Properties.Settings.Default.Save();
            }
        }
    }
}
