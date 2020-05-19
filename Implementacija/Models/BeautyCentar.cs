using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Implementacija.Models
{
    
    public class BeautyCentar
    {
        private string naziv { get; set; }
        private List<Zaposlenik> listaZaposlenika { get; set; }
        private Administrator vlasnikSalona { get; set; }
        private List<Tretman> listaTretmana { get; set; }
        private List<Rezervacija> listaRezervisanihTermina { get; set; }
        private List<Korisnik> listaKorisnika { get; set; }
        private List<Izvjestaj> listaIzvjestaja { get; set; }
        private List<IForma>  listaFormi { get; set; }
        private int brojTelefona { get; set; }
       
        private static BeautyCentar uniqueInstance;
        private ISortiraj strategy { get; set; }

        //private DateTime pocetakRadnogVremena { get; set; }
        //private DateTime krajRadnogVremena { get; set; }

        public void rezervisiTermin(Rezervacija rezervacija) {

            throw new NotImplementedException();
        }

        public void izbrisiTretman (Tretman tretman)
        {
            throw new NotImplementedException();
        }

        public void dodajTretman (string naziv, double cijena, string opis, KategorijaTretmana tipkategorije)
        {
            throw new NotImplementedException();
        }

        public void dodajZaposlenika(string ime, string prezime, string username, string password)
        {
            throw new NotImplementedException();
        }

        public void izbrisiZaposlenika(in String username)
        {
            throw new NotImplementedException();
        }

        public void dodajRegistrovanogKorisnika(string ime, string prezime,string email, string password)
        {
            throw new NotImplementedException();
        }

        public void brisiRezervaciju(string imeRezervacije)
        {
            throw new NotImplementedException();
        }

        public void dodajRezervaciju(string ime, string prezime, string nazivTretmana, string mail, DateTime vrijeme)
        {
            throw new NotImplementedException();
            //provjeriti za sliku sta uraditi
        }

        public Korisnik dajPodatkeOKlijentu(string ime, string prezime)
        {
            throw new NotImplementedException();
        }

        public void azurirajRezervacija(string ime, string prezime, string nazivTretmana, string mail, DateTime vrijeme)
        {
            throw new NotImplementedException();
        }

        public void dodajIzvjestaj(Izvjestaj izvjestaj)
        {
            throw new NotImplementedException();
        }

        public void popuniUplanicu(string ime, string prezime, string nazivTretmana, double cijena, TipPlacanja nacin, int brojRacuna)
        {
            throw new NotImplementedException();
        }

        public BeautyCentar getInstance()
        {
            throw new NotImplementedException();
        }

       /* public void kreirajFormu(Tretman prepureceniTretman, RegistrovaniKorisnik klijent, string opis, Image slika, TipKoze tip, in int sifraForme)
        {
         //problem sa primanjem slike kao parametar,vidjeti u cemu je problem
            throw new NotImplementedException();
        }
*/


        public void sortirajPodatkeOKlijentu()
        {
            throw new NotImplementedException();
        }

        public void dodajKorisnika(Korisnik korisnik)
        {
            throw new NotImplementedException();
        }

        public Korisnik dajKorisnikaNaPoziciji(int index)
        {
            throw new NotImplementedException();
        }


    }
}
