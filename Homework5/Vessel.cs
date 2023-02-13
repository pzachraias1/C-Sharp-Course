

public class Vessel{
    private string name;
    private string type;
    private readonly int hull_number;
    private string crew_compliment;
    private string displacement;
    private double top_speed;
    private int fleet;

    public Vessel(){
        this.name = "";
        this.type = "";
        this.hull_number = 0;
        this.crew_compliment = "";
        this.displacement = "";
        this.top_speed = 0.0;
        this.fleet = 7;
    }

    public Vessel(string name, string type, int hull_num, string crew, string displacement, double top_speed, int fleet){
        this.name = name;
        this.type = type;
        this.hull_number = hull_num;
        this.crew_compliment = crew;
        this.displacement = displacement;
        this.top_speed = top_speed;
        this.fleet = fleet;
    }

    public Vessel(int fleet){
        this.name = "";
        this.type = "";
        this.hull_number = 0;
        this.crew_compliment = "";
        this.displacement = "";
        this.top_speed = 0.0;
        this.fleet = fleet;
    }

    public string Name {
        set {this.name = value;}
        get {return this.name;}
        }
    public string Type{
        set {this.type = value;}
        get {return this.type;}
    }
    public int Hull_number{
        //set {this.hull_number = value;}
        get {return this.hull_number;}
    }
    public string Crew_compliment{
        set {this.crew_compliment = value;}
        get {return this.crew_compliment;}
    }
    public string Displacement{
        set {this.displacement = value;}
        get {return this.displacement;}
    }
    public double Top_speed{
        set {this.top_speed = value;}
        get {return this.top_speed;}
    }

    public int Fleet {
        set {this.fleet = value;}
        get{return this.fleet;}
    }
}