public class DeskQuote
{
    public Desk Desk { get; set; }
    public string CustomerName { get; set; }
    public string RushOption { get; set; }
    public int FinalQuote { get; set; }
    public string QuoteDate { get; set; }

    const int basePrice = 200;
    const int drawerPrice = 50;
    const int surfaceAreaPrice = 1;
    const int oakPrice = 200;
    const int laminatePrice = 100;
    const int pinePrice = 50;
    const int rosewoodPrice = 300;
    const int veneerPrice = 200;

    public int GetRushOrder(string rushOrder, int deskSurfaceArea)
    {
        int rushOrderRate = 0;

        switch (rushOrder)
        {
            case "3-Day Delivery":
                if (deskSurfaceArea < 1000)
                {
                    rushOrderRate = 60;
                }
                else if (deskSurfaceArea > 1000 && deskSurfaceArea < 2000)
                {
                    rushOrderRate = 70;
                }
                else if (deskSurfaceArea > 2000)
                {
                    rushOrderRate = 80;
                }
                break;

            case "5-Day Delivery":
                if (deskSurfaceArea < 1000)
                {
                    rushOrderRate = 40;
                }
                else if (deskSurfaceArea > 1000 && deskSurfaceArea < 2000)
                {
                    rushOrderRate = 50;
                }
                else if (deskSurfaceArea > 2000)
                {
                    rushOrderRate = 60;
                }
                break;

            case "7-Day Delivery":
                if (deskSurfaceArea < 1000)
                {
                    rushOrderRate = 30;
                }
                else if (deskSurfaceArea > 1000 && deskSurfaceArea < 2000)
                {
                    rushOrderRate = 35;
                }
                else if (deskSurfaceArea > 2000)
                {
                    rushOrderRate = 40;
                }
                break;

            default:
                rushOrderRate = 0;
                break;
        }
        return rushOrderRate;

    }

    public int CalcQuote()
    {
        // find surface area of desk
        int surfaceArea = Desk.Depth * Desk.Width;
        int surfaceAreaRate = 0;
        int materialPrice = 0;
        int rushOrderPrice = 0;

        // read rushOrdertxt and place into two dimensional array

        // get surface area rate
        if (surfaceArea > 1000)
        {
            surfaceAreaRate = surfaceArea * surfaceAreaPrice;
        }


        // get drawer rate
        int drawerNumberRate = Desk.NumberOfDrawers * drawerPrice;

        // get material rate
        if (Desk.DeskMaterial == Desk.SurfaceMaterial.Laminate)
        {
            materialPrice = laminatePrice;
        }

        else if (Desk.DeskMaterial == Desk.SurfaceMaterial.Oak)
        {
            materialPrice = oakPrice;
        }

        else if (Desk.DeskMaterial == Desk.SurfaceMaterial.Rosewood)
        {
            materialPrice = rosewoodPrice;
        }

        else if (Desk.DeskMaterial == Desk.SurfaceMaterial.Veneer)
        {
            materialPrice = veneerPrice;
        }
        else if (Desk.DeskMaterial == Desk.SurfaceMaterial.Pine)
        {
            materialPrice = pinePrice;
        }

        // get rush order rate
        rushOrderPrice = GetRushOrder(RushOption, surfaceArea);


        int quote = basePrice + surfaceAreaRate + drawerNumberRate + materialPrice + rushOrderPrice;
        return quote;
    }
}

 

       
