package log4jTest;
class half
{
	public static void main(String[] args)
	{
		int money = 300;
		int wager;
		int count = 0;//lose count
		int bigorsmall = 0;
		int i, j;

		for ( i = 0; i < 10000 && money > 0; i++)
		{
			if (count == 0) wager = 1;
			else
				wager = (int) Math.pow(2, count - 1);
			money -= wager;

			j = (int)(Math.random() *  1000000);
			bigorsmall = j % 2;
			//if (bigorsmall == 0)bigorsmall = 1;
			//else bigorsmall = 0;
			if (bigorsmall == 0)
			{
				money += wager * 2;
				count = 0;
			}
			else
			{
				count ++;
			}
			if (count > 6)
			{
				System.out.println("Turn : " + i +" count is  "+count+ "   wager is "+wager+" money is "+ money);
			}
		}
		System.out.println(i);
	}
}

