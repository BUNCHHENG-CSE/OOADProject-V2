using OOADPROV2.Models;
using OOADPROV2.Utilities.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Commands.Product;

public class AddProductCommand
{
    private readonly Products _product;
    public AddProductCommand(Products product)
    {
        _product = product;
    }

    public void Execute()
    {
        var connection = Helper.Instance.Connection;
        if (connection != null)
        {
            ProductFunc.AddProducts(connection, _product);
        }
    }

}
