public class Tools{
    public string type;
    public string manufacturer;
    public double price;
    public string material;
    public string useFor;
    public bool waterResistance;
    public bool electronic;

    public Tools(){
        this.type = "";
        this.manufacturer = "";
        this.price = 0.0;
        this.useFor = "School work";
        this.waterResistance = false;
        this.electronic = false;
    }

    public Tools(String useFor){
        this.type = "";
        this.manufacturer = "";
        this.price = 0.0;
        this.useFor = useFor;
        this.waterResistance = false;
        this.electronic = false;
    }

    public Tools(string type, string manu, double price, string useFor, bool waterResistance, bool electronic){
        this.type = type;
        this.manufacturer = manu;
        this.price = price;
        this.useFor = useFor;
        this.waterResistance = waterResistance;
        this.electronic = electronic;
    }
}

public class Furniture: Tools{
    public int num_legs;
    public double mass;

    public Furniture():base(){
        this.type = "";
        this.manufacturer = "";
        this.price = 0.0;
        this.useFor = "School work";
        this.waterResistance = true;
        this.electronic = false;
        this.num_legs = 0;
        this.mass = 0.0;
    }

    public Furniture(string type, string manufacturer, double price, string useFor,
    bool waterResistance, bool electronic , int num_legs, double mass): base(type, manufacturer, price, useFor, waterResistance, electronic ){
        this.num_legs = num_legs;
        this.mass = mass;
    }
}

public class Devices: Tools{
    public double watt_use;
    public string processor;

    public Devices(): base(){
        this.type = "";
        this.manufacturer = "";
        this.price = 0.0;
        this.useFor = "School work";
        this.waterResistance = false;
        this.electronic = true;
        this.watt_use = 0.0;
        this.processor = "";
    }

    public Devices(string type, string manufacturer, double price, string useFor,
    bool waterResistance, bool electronic, double watt_use, string processor):base(type, manufacturer, price, useFor, waterResistance, electronic){
        this.watt_use = watt_use;
        this.processor = processor;
    }
}

public class Tables: Furniture{
    public string shape;
    
    public Tables(): base(){
        this.type = "";
        this.manufacturer = "";
        this.price = 0.0;
        this.useFor = "School work";
        this.waterResistance = true;
        this.electronic = false;
        this.num_legs = 0;
        this.mass = 0.0;
        this.shape = "";
    }

    public Tables(string type, string manufacturer, double price, string useFor, bool waterResistance, bool electronic, int num_legs,
    double mass, string shape):base(type, manufacturer, price, useFor, electronic, waterResistance, num_legs, mass){
        this.shape = shape;
    }
}

public class Chairs: Furniture{
    public bool armRest;
    public bool headRest;
    public bool recline;
    public bool wheel;

    public Chairs() :base(){
        this.type = "";
        this.manufacturer = "";
        this.price = 0.0;
        this.useFor = "School work";
        this.waterResistance = true;
        this.electronic = false;
        this.num_legs = 0;
        this.mass = 0.0;
        this.armRest = false;
        this.headRest = false;
        this.wheel = false;
        this.recline = false;
    }

    public Chairs(string type, string manufacturer, double price, string useFor, bool waterResistance, bool electronic, int num_legs,
    double mass, bool armRest, bool headRest, bool recline, bool wheel):base(type, manufacturer, price, useFor, electronic, waterResistance, num_legs, mass){
        this.armRest = armRest;
        this.headRest = headRest;
        this.recline = recline;
        this.wheel = wheel;
    }
}

public class Bed: Furniture{
    public string type_of_bedding;
    public string size_type;
    public bool frame;

    public Bed(): base(){
        this.type = "";
        this.manufacturer = "";
        this.price = 0.0;
        this.useFor = "Rest";
        this.waterResistance = true;
        this.electronic = false;
        this.num_legs = 0;
        this.mass = 0.0;
        this.type_of_bedding = "";
        this.size_type  = "";
        this.frame = false;
    }

    public Bed(string type, string manufacturer, double price, string useFor, bool waterResistance, bool electronic, int num_legs,
    double mass, string type_of_bedding, string size_type, bool frame):base(type, manufacturer, price, useFor, electronic, waterResistance, num_legs, mass){
        this.type_of_bedding = type_of_bedding;
        this.size_type = size_type;
        this.frame = frame;
    }
}

public class Laptops: Devices{
    public int num_port;
    public string keyboard_type;

    public Laptops(): base(){
        this.type = "";
        this.manufacturer = "";
        this.price = 0.0;
        this.useFor = "School work";
        this.waterResistance = false;
        this.electronic = true;
        this.watt_use = 0.0;
        this.processor = "";       
        this.num_port = 0;
        this.keyboard_type = "";
    }

    public Laptops(string type, string manufacturer, double price, string useFor, bool waterResistance, bool electronic, double watt_use,
    string processor, int num_port, string keyboard_type):base(type,manufacturer,price, useFor, waterResistance,electronic,watt_use,processor){
        this.num_port = num_port;
        this.keyboard_type = keyboard_type;
    }
}

public class Phones: Devices{
    public string charger_type;
    public double camera_mp;

    public Phones():base(){
        this.type = "";
        this.manufacturer = "";
        this.price = 0.0;
        this.useFor = "School work";
        this.waterResistance = false;
        this.electronic = true;
        this.watt_use = 0.0;
        this.processor = "";       
        this.charger_type = "";
        this.camera_mp = 0.0;
    }
    
    public Phones(string type, string manufacturer, double price, string useFor, bool waterResistance, bool electronic, double watt_use,
    string processor, string charger_type, double camera_mp):base(type,manufacturer,price, useFor, waterResistance,electronic,watt_use,processor){
        this.charger_type = charger_type;
        this.camera_mp = camera_mp;
    }
}

public class Lamp: Devices{
    public string light_color;

    public Lamp():base(){
        this.type = "";
        this.manufacturer = "";
        this.price = 0.0;
        this.useFor = "School work";
        this.waterResistance = false;
        this.electronic = true;
        this.watt_use = 0.0;
        this.processor = "";       
        this.light_color = "";
    }

    public Lamp(string type, string manufacturer, double price, string useFor, bool waterResistance, bool electronic, double watt_use,
    string processor, string light_color):base(type,manufacturer,price, useFor, waterResistance,electronic,watt_use,processor){
        this.light_color = light_color;
    }
}