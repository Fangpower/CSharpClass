/**
* @author Mikey Dowsett
* Class Invoice represents an invoice with a part number, description, 
* quantity purchased, and a purchase price.
*/
internal class Invoice {
    private int quantity;
    private decimal price;
    public string PartNumber { get; set; }
    public string PartDescription { get; set; }
    
    public int Quantity {
        get {
            return quantity;
        }
        set { 
            if (value >= 0)
                quantity = value;
        }
    }
    public decimal PricePerItem { 
        get {
            return price;
        }
        set {
            if(value >= 0) 
                price = value;
        }
    }

    public Invoice() {
        PricePerItem = Quantity = 0;
        PartNumber = "";
        PartDescription = "";
    }

    public Invoice(string _partNumber, string _description,
    int _quantity, decimal _price) {
        PartNumber = _partNumber;
        PartDescription = _description;
        PricePerItem = _price;
        Quantity = _quantity;
    }

    public decimal GetInvoiceAmount() {
        return Quantity * PricePerItem;
    }
}