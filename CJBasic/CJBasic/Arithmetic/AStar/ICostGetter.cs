namespace CJBasic.Arithmetic.AStar
{
     using global::CJBasic.Geometry;
    using System;
    using System.Drawing;

    public interface ICostGetter
    {
        int GetCost(Point currentNodeLoaction, CompassDirections moveDirection);
    }
}

