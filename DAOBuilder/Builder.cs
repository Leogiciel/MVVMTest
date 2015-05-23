using IModels;
using DAOs;

namespace DAOBuilder
{
    public static class Builder
    {
        public static IModel GetDAO()
        {
            //Determine DAO Type
            return new DAO();
        }
    }
}
