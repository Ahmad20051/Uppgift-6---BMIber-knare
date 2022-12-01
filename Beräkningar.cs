using System;

public class Beräkningar
{
	public Beräkningar()
	{
        float vikt = Convert.ToSingle(txtVikt.Text);
        float längd = Convert.ToSingle(txtLängd.Text);
        float resultat = 0.0F;
        string resultat2 = "";

        resultat = vikt / längd / längd;

        //BMI under 18,5: Undervikt
        //BMI 18,5 – 25: Normalvikt
        //BMI 25 – 30: Övervikt
        //BMI 30.0 och mer: Fetma
        if (resultat < 18.5)
        {
            resultat2 = "Du är underviktig";
        }
        else if (resultat > 18.5 && resultat < 25)
        {
            resultat2 = "Du har en normalvikt";
        }
        else if (resultat > 25 && resultat < 30)
        {
            resultat2 = "Du är överviktig";
        }
        else if (resultat >= 30)
        {
            resultat2 = "Du har fetma";
        }
        txtResultat.Text = "Ditt BMI är: " + resultat.ToString("#.#") + "\r\n" + resultat;
    }
}
