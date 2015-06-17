interface IRectang 
{
    int XUppLeft
    {
        get;
        set;
    }
    int YUppLeft
    {
        get;
        set;
    }
    int XLowRight
    {
        get;
        set;
    }
    int YLowRight
    {
        get;
        set;
    }
    bool AreTheyCross(CRectangular b);
}
class CRectangular : IRectang 
{
    // Fields: 
    private int _xUL, _yUL, _xLR, _yLR;
    public bool AreTheyCross(CRectangular b) 
    {
        bool to_return = false;
        bool bl_conditionX, bl_conditionY;
        bl_conditionX = false;
        bl_conditionY = false;
        if (((this.XUppLeft <= b.XUppLeft) && (b.XUppLeft <= this.XLowRight))||((this.XUppLeft <= b.XLowRight) && (b.XLowRight <= this.XLowRight))) bl_conditionX = true;
        if (((this.YUppLeft >= b.YUppLeft) && (b.YUppLeft >= this.YLowRight))||((this.YUppLeft >= b.YLowRight) && (b.YLowRight >= this.YLowRight))) bl_conditionY = true;

        to_return = bl_conditionX || bl_conditionY;
        return to_return;
    }
    public CRectangular(int x1, int y1, int x2, int y2)
    {
        _xUL = x1;
        _yUL = y1;
        _xLR = x2;
        _yLR = y2;
        if (x1 < x2)
        {
            _xUL = x1;
            _xLR = x2;
        }
        else 
        {
            _xUL = x2;
            _xLR = x1;
        }
        if (y1 > y2)
        {
            _yUL = y1;
            _yLR = y2;
        }
        else 
        {
            _yUL = y2;
            _yLR = y1;
        }
    }
    public int XUppLeft
    {
        get
        {
            return _xUL;
        }
        set
        {
            _xUL = value;
        }
    }
    public int XLowRight 
    {
        get 
        {
            return _xLR;
        }
        set 
        {
            _xLR = value;
        }
    }
    public int YUppLeft 
    {
        get 
        {
            return _yUL;
        }
        set 
        {
            _yUL = value;
        }
    }
    public int YLowRight 
    {
        get 
        {
            return _yLR;
        }
        set 
        {
            _yLR = value;
        }
    }
}

private void cmdRun_Click(object sender, EventArgs e)
{
    CRectangular p = new CRectangular(-4, 3, 2, 1);
    CRectangular q = new CRectangular(-2, 5, -1, -1);           //(-100, -200, -300, -400);
    bool rez = p.AreTheyCross(q);
    if (rez) MessageBox.Show("They are crossing");
    else MessageBox.Show("They are not crossing");

    // if (AreTheyCross(p, q)) MessageBox.Show("They are crossing");
    // else MessageBox.Show("They are not crossing");

    MessageBox.Show("(" + p.XUppLeft.ToString() + "," + p.YUppLeft.ToString() + "," + p.XLowRight.ToString() + "," + p.YLowRight.ToString() + ")");
    CRectangular[] rectArray = new CRectangular[3]
    {
         new CRectangular(1,2,3,0),
         new CRectangular(-1,2,4,7),
         new CRectangular(7,-8,9,10),
    };
    for (int i = 0; i < rectArray.Length; i++) 
    {
        MessageBox.Show("(" + rectArray[i].XUppLeft.ToString() + "," + rectArray[i].YUppLeft.ToString() + "," + rectArray[i].XLowRight.ToString() + "," + rectArray[i].YLowRight.ToString() + ")");
    }

}
