using System;

namespace DataAccessLogicLayer
{
    public static class PizzaHelper
    {
        public static string GetENameById(int id)
        {
            return SqlHelper.GetENameById(id);
        }
    }
}
