using OOADPROV2.Utilities.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Commands.Product;

class DeleteProductCommand
{
    private readonly int _productId;

    public DeleteProductCommand(int productId)
    {
        _productId = productId;
    }

    public void Execute()
    {
        var connection = Helper.Instance.Connection;
        if (connection != null)
        {
            ProductFunc.DeleteProducts(connection, _productId);
        }
    }

}
