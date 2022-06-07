using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebServicePartieClient
{
    public partial class fenetrePrincipal : Form
         
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public fenetrePrincipal()
        {
            InitializeComponent();
            random = new Random();
        }
        //nous sélectionnons une couleur aléatoire parmi les couleurs du thème
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            //si la couleur a déjà été sélectionnée, nous sélectionnons à nouveau pour en choisir une autre
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
                
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            /*on met en surbrillance le bouton qui a été cliqué(formulaire actif)
                    1.nous sélectionnons une couleur aléatoire pour le thème(facultatif,
            vous pouvez utiliser une seule couleur pour mettre en surbrillance le bouton)
                    2.nous changeons la couleur de fond du bouton
                    3.Nous changeons la couleur de la police du bouton
                    4.nous modifions la taille de la police du bouton*/
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    //En activant ou en surlignant un bouton, on augmente la taille de l'effet font-zoom (dans mon cas à 12.5)
                    currentButton.Font =  new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
                  /*  panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;*/
                }
            }
        }

        //  nous désactivons la surbrillance des valeurs par défaut du bouton
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    //
                    previousBtn.BackColor = Color.FromArgb(60, 179, 113);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);

                }
            }
        }

        private void fenetrePrincipal_Load(object sender, EventArgs e)
        {

        }

        private void acceuil_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void structures_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void localisation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void rdv_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void contact_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void autres_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
