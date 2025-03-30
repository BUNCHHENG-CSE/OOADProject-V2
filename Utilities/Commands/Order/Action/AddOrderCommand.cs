using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace OOADPROV2.Utilities.Commands.Order.Action
{
    public class AddOrderCommand : ICommand<int>
    {
        private readonly OOADPROV2.Models.Orders _order;
        public AddOrderCommand(OOADPROV2.Models.Orders order)
        {
            _order = order;
        }

        public int Execute()
        {
            SqlCommand cmd = new SqlCommand("spInsertOrderReturnId", Helper.Instance.OpenConnection())
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@CustomerId", _order.Customer.CustomerID);
            cmd.Parameters.AddWithValue("@DateOrder", _order.DateOrder);
            cmd.Parameters.AddWithValue("@TotalPrice", _order.TotalPrice);
            cmd.Parameters.AddWithValue("@StaffID", _order.StaffID);
            try
            {
                int orderId = Convert.ToInt32(cmd.ExecuteScalar());
                return orderId;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error inserting order: {ex.Message}");
            }
            finally
            {
                cmd.Dispose();
                Helper.Instance.CloseConnection();
            }
        }
    }
}
