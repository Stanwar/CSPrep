class TreeNode{
    private int _Indentifier;
    public int Indentifier {
        get{
            return _Indentifier;
        }

        set{
            _Indentifier = value;
        }
    }

    public TreeNode Left = null;
    public TreeNode Right = null;

    public TreeNode (int id){
        Indentifier = id;
    }
}