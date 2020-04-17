package log4jTest;

class dicdo
{
	public static void main(String[] args)
	{
		
		int a, b, c, total;
		int money = 200;
		int wager;
		int count = 0;//lose count
		int bigorsmall = 0;
		int i, j;
		a = (int) (Math.random() * 10000);
		a %= 6;
		a += 1;
		b = (int) (Math.random() * 10000);
		b %= 6;
		b += 1;
		c = (int) (Math.random() * 10000);
		c %= 6;
		c += 1;
		total = a + b + c;

		for ( i = 0; i < 10000 && money > 0; i++)
		{
			if (count == 0) wager = 1;
			else
				wager = (int) Math.pow(2, count - 1);
			//  if (count >= 5)
			//      System.out.println("Turn : " + i + "   Wager is " + wager + " count is " + count + "  money is " + (money - wager));
			money -= wager;

			a = (int) (Math.random() * 1000000);
			a %= 6;
			a += 1;
			b = (int) (Math.random() * 1000000);
			b %= 6;
			b += 1;
			c = (int) (Math.random() * 1000000);
			c %= 6;
			c += 1;
			total = a + b + c;
			
			if (a == b && b == c)
			{
				System.out.println("a = b = c " + a + " " + b + " " + c);
				count++;
				continue;
			}
			j = (int)(Math.random() *  1000000);
			bigorsmall = j % 2;
			//if (bigorsmall == 0)bigorsmall = 1;
			//else bigorsmall = 0;
			if ((bigorsmall == 0 && total <= 10) || (bigorsmall == 1 && total >= 11) )
			{
				money += wager * 2;
				count = 0;
			}
			else
			{
				//  System.out.println(a + "  " + b + "  " + c + "  " + total + "  " + bigorsmall);
				count ++;
			}
			if (count > 6)
			{
				System.out.println("Turn : " + i + "   Wager is " + wager + " count is " + count + "  money is " + (money - wager));
				System.out.println(a + "  " + b + "  " + c + "  " + total + "  " + bigorsmall);
			}
		}
		System.out.println(i);
	}

}

