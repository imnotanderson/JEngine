

public struct JPoint  {
	public static JPoint Zero {
		get{
			return new JPoint(0,0);
		}
	}
	public float x, y;

	public JPoint(float x,float y)
	{
		this.x = x;
		this.y = y;
	}

	//取反--
	public JPoint Contrary{
		get{
			return new JPoint(-x,-y);
		}
	}

	public JPoint Normal{
		get{
			float mod = Mod;
			return new JPoint(x/mod,y/mod);
		}
	}

	public static JPoint operator +(JPoint p1,JPoint p2)
	{
		return new JPoint (p1.x + p2.x, p1.y + p2.y);
	}

	public static JPoint operator -(JPoint p1,JPoint p2)
	{
		return new JPoint (p1.x - p2.x, p1.y - p2.y);
	}

	public float Mod{
		get{
			return (float)System.Math.Sqrt( x*x+y*y);
		}
	}
}
