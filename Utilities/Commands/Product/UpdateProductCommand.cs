using OOADPROV2.Models;
using OOADPROV2.Utilities.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Commands.Product;

class UpdateProductCommand
{
    private readonly Products _product;

    public UpdateProductCommand(Products product)
    {
        _product = product;
    }

    public void Execute()
    {
        var connection = Helper.Instance.Connection;
        if (connection != null)
        {
            ProductFunc.UpdateProducts(connection, _product);
        }
    }

}
