using System;
using System.Collections.Generic;
using System.Text;

namespace lab_9;
internal class RightTriangle
{
    private double _a;
    private double _b;

    public RightTriangle()
    {
        _a = 0;
        _b = 0;
    }

    public RightTriangle(double _a, double _b)
    {
        if (_a > 0 && _b > 0)
        {
            this._a = _a;
            this._b = _b;
        }
        else
        {
            Console.WriteLine("Ошибка ввода!");
        }
    }

    public double A
    {
        get
        {
            return _a;
        }
        set
        {
            this._a = value;
        }
    }
    public double B
    {
        get
        {
            return _b;
        }
        set
        {
            this._b = value;
        }
    }

    public double CalcArea()
    {
        if (_a > 0 && _b > 0)
        {
            return _a * _b / 2;
        }
        else
        {
            return 0;
        }
    }

    public override string ToString()
    {
        return "a = " + _a + " b = " + _b;
    }

    public static RightTriangle operator ++(RightTriangle triangle)
    {
        return new RightTriangle(triangle._a * 2, triangle._b * 2);
    }

    public static RightTriangle operator --(RightTriangle triangle)
    {
        return new RightTriangle(triangle._a / 2, triangle._b / 2);
    }

    public static explicit operator double(RightTriangle triangle)
    {
        if (triangle._a > 0 && triangle._b > 0)
        {
            return triangle.CalcArea();
        }
        else
        {
            return -1;
        }
    }

    public static implicit operator bool(RightTriangle triangle)
    {
        if (triangle._a > 0 && triangle._b > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool operator <=(RightTriangle a, RightTriangle b)
    {
        return a.CalcArea() <= b.CalcArea();
    }

    public static bool operator >=(RightTriangle a, RightTriangle b)
    {
        return a.CalcArea() >= b.CalcArea();
    }
}