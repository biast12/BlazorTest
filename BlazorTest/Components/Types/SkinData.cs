public class SkinData
{
    public string _id { get; set; }
    public string legend { get; set; }
    public List<SkinDetail> details { get; set; }
    public int __v { get; set; }

    public SkinData(string _id, string legend, List<SkinDetail> details, int __v)
    {
        this._id = _id;
        this.legend = legend;
        this.details = details;
        this.__v = __v;
    }
}

public class SkinDetail
{
    public string ingamename { get; set; }
    public string model { get; set; }
    public string texture { get; set; }
    public string _id { get; set; }
    public string animation { get; set; }

    public SkinDetail(string ingamename, string model, string texture, string _id, string animation)
    {
        this.ingamename = ingamename;
        this.model = model;
        this.texture = texture;
        this._id = _id;
        this.animation = animation;
    }
}