class CharNode{
    private char _Indentifier;
    public char Indentifier {
        get{
            return _Indentifier;
        }

        set{
            _Indentifier = value;
        }
    }

    public CharNode Left = null;
    public CharNode Right = null;

    public CharNode (char id){
        Indentifier = id;
    }
}