using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using System.Xml;


/// <summary>
/// Summary description for XMLServices
/// </summary>
public class XMLServices
{
    public XMLServices()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public List<Product> getProducts(string path)
    {
        String xmlFile = path +  "/ProductsDB.xml";

        // Define a settings which will be used by the reader 
        XmlReaderSettings xmlSettings = new XmlReaderSettings();
        xmlSettings.IgnoreWhitespace = true;
        xmlSettings.IgnoreComments = true;

        //  int TeamMemberCount = 0;

        List<Product> lp = new List<Product>();

        // using(  ) is used when accessing a resource, it implements the try/catch model behind the scene and
        // takes care of disposing the resource after usage
        using (XmlReader XmlRdr = XmlReader.Create(xmlFile, xmlSettings))
        {
            while (XmlRdr.Read())
            {
                if (XmlRdr.NodeType == XmlNodeType.Element && XmlRdr.LocalName == "Item")
                {

                   // Product p = new Product(int.Parse(XmlRdr.GetAttribute(0)),XmlRdr.GetAttribute(1), double.Parse(XmlRdr.GetAttribute(2)), int.Parse(XmlRdr.GetAttribute(3)), XmlRdr.GetAttribute(4), Convert.ToBoolean(int.Parse(XmlRdr.GetAttribute(5))));
                    Product p = new Product();
                    p.Id = int.Parse(XmlRdr.GetAttribute(0));
                    p.Title = XmlRdr.GetAttribute(1);
                    p.Price = double.Parse(XmlRdr.GetAttribute(2));
                    p.Inventory = int.Parse(XmlRdr.GetAttribute(3));
                    p.ImagePath = XmlRdr.GetAttribute(4);
                    p.Available = Convert.ToBoolean(int.Parse(XmlRdr.GetAttribute(5)));
                    p.category.Id = int.Parse(XmlRdr.GetAttribute(6));
                    lp.Add(p);
                }
            }
        }
        return lp;

        // Response.Write(String.Format("There are {0} team members in the department", TeamMemberCount.ToString()));
    }
}
