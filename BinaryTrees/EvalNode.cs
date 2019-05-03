class EvalNode{
    private string _Indentifier;
    public string Indentifier {
        get{
            return _Indentifier;
        }

        set{
            _Indentifier = value;
        }
    }

    public EvalNode Left = null;
    public EvalNode Right = null;

    public EvalNode(string id){
        Indentifier = id;
    }
}