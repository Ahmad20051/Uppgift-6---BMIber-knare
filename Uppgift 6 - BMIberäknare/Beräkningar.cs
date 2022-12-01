using System;

public class Beräkningar
{
    public Beräkningar(TextBox txtVikt, TextBox txtLängd, TextBox txtResultat)
	{
        //Denna funktion tar texten och konverterar den till en float
        float vikt = Convert.ToSingle(txtVikt.Text);
        float längd = Convert.ToSingle(txtLängd.Text);
        float resultat = 0.0F;
        string resultat2 = "";

        //Här finns beräkningen för själva BMI beräknaren
        resultat = vikt / längd / längd;

        //BMI under 18,5: Undervikt
        //BMI 18,5 – 25: Normalvikt
        //BMI 25 – 30: Övervikt
        //BMI 30.0 och mer: Fetma

        //Om resultatet är mindre än 18.5 printas "Du är underviktig"
        if (resultat < 18.5)
        {
            resultat2 = "Du är underviktig";
        }
        //Om resultatet är större än 18.5 men mindre än 25 printas "Du har en normalvikt"
        else if (resultat > 18.5 && resultat < 25)
        {
            resultat2 = "Du har en normalvikt";
        }
        //Om resultatet är större än 25 men mindre än 30 printas "Du är överviktig"
        else if (resultat > 25 && resultat < 30)
        {
            resultat2 = "Du är överviktig";
        }
        //Om resultatet är större än eller lika med 30 printas "Du har fetma"
        else if (resultat >= 30)
        {
            resultat2 = "Du har fetma";
        }
        //Här finns funktionen för vad TextBoxen ska säga. Först ska den skriva "Ditt BMI värde är: " och sedan ska den ta resultaten och omvanlda det till en sträng och sist printar den resultaten 
        txtResultat.Text = "Ditt BMI värde är: " + resultat.ToString("#.#") + "\r" + "\n" + resultat2;
    }
}