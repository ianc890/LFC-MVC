using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LFCMVC.Models
{
    public class LFCInitializer : DropCreateDatabaseAlways<LFCContext>
    {
        protected override void Seed(LFCContext context)
        {
            //base.Seed(context);

            

            //create Competitions
            var competitions = new List<Competition>();
            Competition epl = new Competition();
            epl.CompetitionId = 1;
            epl.Image = "epl.png";
            epl.Name = "English Premiership";
            competitions.Add(epl);

            Competition fa = new Competition();
            fa.CompetitionId = 2;
            fa.Image = "facup.png";
            fa.Name = "FA Cup";
            competitions.Add(fa);

            Competition capital = new Competition();
            capital.Image = "capcup.png";
            capital.CompetitionId = 3;
            capital.Name = "Capital One Cup";
            competitions.Add(capital);

            Competition europa = new Competition();
            europa.CompetitionId = 4;
            europa.Image = "uel.png";
            europa.Name = "Europa League";
            competitions.Add(europa);

            Competition friendly = new Competition();
            friendly.CompetitionId = 5;
            friendly.Image = "friendly.png";
            friendly.Name = "Friendly";
            competitions.Add(friendly);

            context.SaveChanges();

            //create Player Positions
            var positions = new List<PlayerPosition>();
            PlayerPosition gk = new PlayerPosition();
            gk.PlayerPositionId = 1;
            gk.Position = "GK";
            gk.Description = "Goalkeeper";
            positions.Add(gk);

            PlayerPosition rb = new PlayerPosition();
            rb.PlayerPositionId = 2;
            rb.Position = "RB";
            rb.Description = "Defender";
            positions.Add(rb);

            PlayerPosition cb = new PlayerPosition();
            cb.PlayerPositionId = 3;
            cb.Position = "CB";
            cb.Description = "Defender";
            positions.Add(cb);

            PlayerPosition lb = new PlayerPosition();
            lb.PlayerPositionId = 4;
            lb.Position = "LB";
            lb.Description = "Defender";
            positions.Add(lb);

            PlayerPosition rm = new PlayerPosition();
            rm.PlayerPositionId = 5;
            rm.Position = "RM";
            rm.Description = "Midfielder";
            positions.Add(rm);

            PlayerPosition ram = new PlayerPosition();
            ram.PlayerPositionId = 6;
            ram.Position = "RAM";
            ram.Description = "Midfielder";
            positions.Add(ram);

            PlayerPosition cdm = new PlayerPosition();
            cdm.PlayerPositionId = 7;
            cdm.Position = "CDM";
            cdm.Description = "Midfielder";
            positions.Add(cdm);

            PlayerPosition cm = new PlayerPosition();
            cm.PlayerPositionId = 8;
            cm.Position = "CM";
            cm.Description = "Midfielder";
            positions.Add(cm);

            PlayerPosition cam = new PlayerPosition();
            cam.PlayerPositionId = 9;
            cam.Position = "CAM";
            cam.Description = "Midfielder";
            positions.Add(cam);

            PlayerPosition lam = new PlayerPosition();
            lam.PlayerPositionId = 10;
            lam.Position = "LAM";
            lam.Description = "Midfielder";
            positions.Add(lam);

            PlayerPosition lm = new PlayerPosition();
            lm.PlayerPositionId = 11;
            lm.Position = "LM";
            lm.Description = "Midfielder";
            positions.Add(lm);

            PlayerPosition rw = new PlayerPosition();
            rw.PlayerPositionId = 12;
            rw.Position = "RW";
            rw.Description = "Forward";
            positions.Add(rw);

            PlayerPosition lw = new PlayerPosition();
            lw.PlayerPositionId = 13;
            lw.Position = "LW";
            lw.Description = "Forward";
            positions.Add(lw);

            PlayerPosition cf = new PlayerPosition();
            cf.PlayerPositionId = 14;
            cf.Position = "CF";
            cf.Description = "Forward";
            positions.Add(cf);

            PlayerPosition st = new PlayerPosition();
            st.PlayerPositionId = 15;
            st.Position = "ST";
            st.Description = "Forward";
            positions.Add(st);

            context.SaveChanges();

            //create Teams
            var teams = new List<Team>();
            Team lfc = new Team();
            lfc.TeamId = 1;
            lfc.Name = "Liverpool FC";
            teams.Add(lfc);

            Team lfc21 = new Team();
            lfc21.TeamId = 2;
            lfc21.Name = "Liverpool FC U-21's";
            teams.Add(lfc21);

            context.SaveChanges();

            //create Players
            var players = new List<Player>();
            Player player = new Player();
            player.Image = "Mignolet.jpg";
            player.FirstName = "Simon";
            player.LastName = "Mignolet";
            player.Age = 27;
            player.Nationality = "Belgium";
            player.SquadNumber = 22;
            player.PlayerPositionId = 5;
            players.Add(player);

            Player playerTwo = new Player();
            playerTwo.Image = "Bogdan.jpg";
            playerTwo.FirstName = "Adam";
            playerTwo.LastName = "Bogdan";
            playerTwo.Age = 28;
            playerTwo.Nationality = "Hungary";
            playerTwo.SquadNumber = 34;
            players.Add(playerTwo);

            Player playerThree = new Player();
            playerThree.Image = "Fulton.jpg";
            playerThree.FirstName = "Ryan";
            playerThree.LastName = "Fulton";
            playerThree.Age = 19;
            playerThree.Nationality = "England";
            playerThree.SquadNumber = 39;
            players.Add(playerThree);

            Player playerFour = new Player();
            playerFour.Image = "Clyne.jpg";
            playerFour.FirstName = "Nathaniel";
            playerFour.LastName = "Clyne";
            playerFour.Age = 24;
            playerFour.Nationality = "England";
            playerFour.SquadNumber = 2;
            players.Add(playerFour);

            Player playerFive = new Player();
            playerFive.Image = "Flanagan.jpg";
            playerFive.FirstName = "Jon";
            playerFive.LastName = "Flanagan";
            playerFive.Age = 22;
            playerFive.Nationality = "England";
            playerFive.SquadNumber = 38;
            players.Add(playerFive);

            Player playerSix = new Player();
            playerSix.Image = "Toure.jpg";
            playerSix.FirstName = "Kolo";
            playerSix.LastName = "Toure";
            playerSix.Age = 34;
            playerSix.Nationality = "Ivory Coast";
            playerSix.SquadNumber = 4;
            players.Add(playerSix);

            Player playerSeven = new Player();
            playerSeven.Image = "Lovren.jpg";
            playerSeven.FirstName = "Dejan";
            playerSeven.LastName = "Lovren";
            playerSeven.Age = 26;
            playerSeven.Nationality = "Croatia";
            playerSeven.SquadNumber = 6;
            players.Add(playerSeven);

            Player playerEight = new Player();
            playerEight.Image = "Skrtel.jpg";
            playerEight.FirstName = "Martin";
            playerEight.LastName = "Skrtel";
            playerEight.Age = 30;
            playerEight.Nationality = "Slovenia";
            playerEight.SquadNumber = 37;
            players.Add(playerEight);

            Player playerNine = new Player();
            playerNine.Image = "Sakho.jpg";
            playerNine.FirstName = "Mamadou";
            playerNine.LastName = "Sakho";
            playerNine.Age = 25;
            playerNine.Nationality = "France";
            playerNine.SquadNumber = 17;
            players.Add(playerNine);

            Player playerTen = new Player();
            playerTen.Image = "Gomez.jpg";
            playerTen.FirstName = "Joe";
            playerTen.LastName = "Gomez";
            playerTen.Age = 18;
            playerTen.Nationality = "England";
            playerTen.SquadNumber = 12;
            players.Add(playerTen);

            Player playerEleven = new Player();
            playerEleven.Image = "Cleary.jpg";
            playerEleven.FirstName = "Daniel";
            playerEleven.LastName = "Cleary";
            playerEleven.Age = 19;
            playerEleven.Nationality = "Ireland";
            playerEleven.SquadNumber = 58;
            players.Add(playerEleven);

            Player playerTwelve = new Player();
            playerTwelve.Image = "Moreno.jpg";
            playerTwelve.FirstName = "Alberto";
            playerTwelve.LastName = "Moreno";
            playerTwelve.Age = 23;
            playerTwelve.Nationality = "Spain";
            playerTwelve.SquadNumber = 18;
            players.Add(playerTwelve);

            Player playerThirtheen = new Player();
            playerThirtheen.Image = "Enrique.jpg";
            playerThirtheen.FirstName = "Jose";
            playerThirtheen.LastName = "Enrique";
            playerThirtheen.Age = 29;
            playerThirtheen.Nationality = "Spain";
            playerThirtheen.SquadNumber = 3;
            players.Add(playerThirtheen);

            Player playerFourteen = new Player();
            playerFourteen.Image = "Ibe.jpg";
            playerFourteen.FirstName = "Jordan";
            playerFourteen.LastName = "Ibe";
            playerFourteen.Age = 19;
            playerFourteen.Nationality = "England";
            playerFourteen.SquadNumber = 33;
            players.Add(playerFourteen);

            Player playerFiveteen = new Player();
            playerFiveteen.Image = "Lucas.jpg";
            playerFiveteen.FirstName = "Lucas";
            playerFiveteen.LastName = "Leiva";
            playerFiveteen.Age = 28;
            playerFiveteen.Nationality = "Brazil";
            playerFiveteen.SquadNumber = 21;
            players.Add(playerFiveteen);

            Player playerSixteen = new Player();
            playerSixteen.Image = "Can.jpg";
            playerSixteen.FirstName = "Emre";
            playerSixteen.LastName = "Can";
            playerSixteen.Age = 21;
            playerSixteen.Nationality = "Germany";
            playerSixteen.SquadNumber = 23;
            players.Add(playerSixteen);

            Player playerSeventeen = new Player();
            playerSeventeen.Image = "Rossiter.jpg";
            playerSeventeen.FirstName = "Jordan";
            playerSeventeen.LastName = "Rossiter";
            playerSeventeen.Age = 18;
            playerSeventeen.Nationality = "England";
            playerSeventeen.SquadNumber = 46;
            players.Add(playerSeventeen);

            Player playerEighteen = new Player();
            playerEighteen.Image = "Allen.jpg";
            playerEighteen.FirstName = "Joe";
            playerEighteen.LastName = "Allen";
            playerEighteen.Age = 25;
            playerEighteen.Nationality = "Wales";
            playerEighteen.SquadNumber = 24;
            players.Add(playerEighteen);

            Player playerNineteen = new Player();
            playerNineteen.Image = "Henderson.jpg";
            playerNineteen.FirstName = "Jordan";
            playerNineteen.LastName = "Henderson";
            playerNineteen.Age = 25;
            playerNineteen.Nationality = "England";
            playerNineteen.SquadNumber = 14;
            players.Add(playerNineteen);

            Player playerTwenty = new Player();
            playerTwenty.Image = "Milner.jpg";
            playerTwenty.FirstName = "James";
            playerTwenty.LastName = "Milner";
            playerTwenty.Age = 29;
            playerTwenty.Nationality = "England";
            playerTwenty.SquadNumber = 7;
            players.Add(playerTwenty);

            Player playerTwentyOne = new Player();
            playerTwentyOne.Image = "Randall.jpg";
            playerTwentyOne.FirstName = "Connor";
            playerTwentyOne.LastName = "Randall";
            playerTwentyOne.Age = 20;
            playerTwentyOne.Nationality = "England";
            playerTwentyOne.SquadNumber = 56;
            players.Add(playerTwentyOne);

            Player playerTwentyTwo = new Player();
            playerTwentyTwo.Image = "Chirivella.jpg";
            playerTwentyTwo.FirstName = "Pedro";
            playerTwentyTwo.LastName = "Chirivella";
            playerTwentyTwo.Age = 18;
            playerTwentyTwo.Nationality = "Spain";
            playerTwentyTwo.SquadNumber = 68;
            players.Add(playerTwentyTwo);

            Player playerTwentyThree = new Player();
            playerTwentyThree.Image = "Dunn.jpg";
            playerTwentyThree.FirstName = "Jack";
            playerTwentyThree.LastName = "Dunn";
            playerTwentyThree.Age = 21;
            playerTwentyThree.Nationality = "England";
            playerTwentyThree.SquadNumber = 41;
            players.Add(playerTwentyThree);

            Player playerTwentyFour = new Player();
            playerTwentyFour.Image = "Brannagan.jpg";
            playerTwentyFour.FirstName = "Cameron";
            playerTwentyFour.LastName = "Brannagan";
            playerTwentyFour.Age = 19;
            playerTwentyFour.Nationality = "England";
            playerTwentyFour.SquadNumber = 32;
            players.Add(playerTwentyFour);

            Player playerT = new Player();
            playerT.Image = "Teixeira.jpg";
            playerT.FirstName = "João Carlos";
            playerT.LastName = "Teixeira";
            playerT.Age = 22;
            playerT.Nationality = "Portugal";
            playerT.SquadNumber = 53;
            players.Add(playerT);

            Player playerTwentyFive = new Player();
            playerTwentyFive.Image = "Lallana.jpg";
            playerTwentyFive.FirstName = "Adam";
            playerTwentyFive.LastName = "Lallana";
            playerTwentyFive.Age = 27;
            playerTwentyFive.Nationality = "England";
            playerTwentyFive.SquadNumber = 20;
            players.Add(playerTwentyFive);

            Player playerTwentySix = new Player();
            playerTwentySix.Image = "Coutinho.jpg";
            playerTwentySix.FirstName = "Philippe";
            playerTwentySix.LastName = "Coutinho";
            playerTwentySix.Age = 23;
            playerTwentySix.Nationality = "Brazil";
            playerTwentySix.SquadNumber = 10;
            players.Add(playerTwentySix);

            Player playerTwentySeven = new Player();
            playerTwentySeven.Image = "Firmino.jpg";
            playerTwentySeven.FirstName = "Roberto";
            playerTwentySeven.LastName = "Firmino";
            playerTwentySeven.Age = 24;
            playerTwentySeven.Nationality = "Brazil";
            playerTwentySeven.SquadNumber = 11;
            players.Add(playerTwentySeven);

            Player playerTwentyEight = new Player();
            playerTwentyEight.Image = "Origi.jpg";
            playerTwentyEight.FirstName = "Divock";
            playerTwentyEight.LastName = "Origi";
            playerTwentyEight.Age = 20;
            playerTwentyEight.Nationality = "Belgium";
            playerTwentyEight.SquadNumber = 27;
            players.Add(playerTwentyEight);

            Player playerTwentyNine = new Player();
            playerTwentyNine.Image = "Ings.jpg";
            playerTwentyNine.FirstName = "Danny";
            playerTwentyNine.LastName = "Ings";
            playerTwentyNine.Age = 23;
            playerTwentyNine.Nationality = "England";
            playerTwentyNine.SquadNumber = 28;
            players.Add(playerTwentyNine);

            Player playerThirthy = new Player();
            playerThirthy.Image = "Benteke.jpg";
            playerThirthy.FirstName = "Christian";
            playerThirthy.LastName = "Benteke";
            playerThirthy.Age = 24;
            playerThirthy.Nationality = "Belgium";
            playerThirthy.SquadNumber = 9;
            players.Add(playerThirthy);

            Player playerThirthyOne = new Player();
            playerThirthyOne.Image = "Sturridge.jpg";
            playerThirthyOne.FirstName = "Daniel";
            playerThirthyOne.LastName = "Sturridge";
            playerThirthyOne.Age = 26;
            playerThirthyOne.Nationality = "England";
            playerThirthyOne.SquadNumber = 15;
            players.Add(playerThirthyOne);

            Player playerThirthyTwo = new Player();
            playerThirthyTwo.Image = "Sinclair.jpg";
            playerThirthyTwo.FirstName = "Jerome";
            playerThirthyTwo.LastName = "Sinclair";
            playerThirthyTwo.Age = 19;
            playerThirthyTwo.Nationality = "England";
            playerThirthyTwo.SquadNumber = 48;
            players.Add(playerThirthyTwo);


            //create Fixtures
            var fixtures = new List<Fixture>();
            Fixture fixture = new Fixture();
            fixture.Date = DateTime.Parse("2015-07-14 14:00:00");
            fixture.Stadium = "Rajamangala National Stadium";
            fixture.HomeTeam = "Thailand All-Stars";
            fixture.HomeScore = 0;
            fixture.AwayScore = 4;
            fixture.AwayTeam = "Liverpool";
            fixtures.Add(fixture);

            Fixture fixtureTwo = new Fixture();
            fixtureTwo.Date = DateTime.Parse("2015-07-17 09:45:00");
            fixtureTwo.Stadium = "Suncorp Stadium";
            fixtureTwo.HomeTeam = "Brisbane";
            fixtureTwo.HomeScore = 1;
            fixtureTwo.AwayScore = 2;
            fixtureTwo.AwayTeam = "Liverpool";
            fixtures.Add(fixtureTwo);

            Fixture fixtureThree = new Fixture();
            fixtureThree.Date = DateTime.Parse("2015-07-20 10:30:00");
            fixtureThree.Stadium = "Coopers Stadium";
            fixtureThree.HomeTeam = "Adelaide United";
            fixtureThree.HomeScore = 0;
            fixtureThree.AwayScore = 2;
            fixtureThree.AwayTeam = "Liverpool";
            fixtures.Add(fixtureThree);

            Fixture fixtureFour = new Fixture();
            fixtureFour.Date = DateTime.Parse("2015-07-24 13:45:00");
            fixtureFour.Stadium = "Bukit Jalil National Stadium";
            fixtureFour.HomeTeam = "Malaysia All-Stars XI";
            fixtureFour.HomeScore = 1;
            fixtureFour.AwayScore = 1;
            fixtureFour.AwayTeam = "Liverpool";
            fixtures.Add(fixtureFour);

            Fixture fixtureFive = new Fixture();
            fixtureFive.Date = DateTime.Parse("2015-08-01 17:30:00");
            fixtureFive.Stadium = "Sonera Stadium";
            fixtureFive.HomeTeam = "HJK Helsinki";
            fixtureFive.HomeScore = 0;
            fixtureFive.AwayScore = 2;
            fixtureFive.AwayTeam = "Liverpool";
            fixtures.Add(fixtureFive);

            Fixture fixtureSix = new Fixture();
            fixtureSix.Date = DateTime.Parse("2015-08-02 16:00:00");
            fixtureSix.Stadium = "The County Ground";
            fixtureSix.HomeTeam = "Swindon Town";
            fixtureSix.HomeScore = 1;
            fixtureSix.AwayScore = 2;
            fixtureSix.AwayTeam = "Liverpool";
            fixtures.Add(fixtureSix);

            //create Honours
            var honours = new List<Honour>();
            Honour league = new Honour();
            league.Image = "pl.png";
            league.Award = "League Champions";
            league.Amount = 18;
            league.Season = "1900-01, 1905-06, 1921-22, 1922-23, 1946-47, 1963-64, 1965-66, 1972-73, 1975-76, 1976-77, 1978-79, 1979-80, 1981-82, 1982-83, 1983-84, 1985-86, 1987-88, 1989-90";
            league.Type = "Domestic";
            honours.Add(league);

            Honour faCup = new Honour();
            faCup.Image = "faTrophy.png";
            faCup.Award = "FA Cup";
            faCup.Amount = 7;
            faCup.Season = "1964-65, 1973-74, 1985-86, 1988-89, 1991-92, 2000-01, 2005-06";
            faCup.Type = "Domestic";
            honours.Add(faCup);

            Honour capCup = new Honour();
            capCup.Image = "lc.png";
            capCup.Award = "Capital One Cup";
            capCup.Amount = 8;
            capCup.Season = "1980-81, 1981-82, 1982-83, 1983-84, 1994-95, 2000-01, 2002-03, 2011-12";
            capCup.Type = "Domestic";
            honours.Add(capCup);

            Honour charity = new Honour();
            charity.Image = "cs.png";
            charity.Award = "FA Community Shield Winner";
            charity.Amount = 15;
            charity.Season = "1964, 1965, 1966, 1974, 1976, 1977, 1979, 1980, 1982, 1986, 1988, 1989, 1990, 2001, 2006";
            charity.Type = "Domestic";
            honours.Add(charity);

            Honour euro = new Honour();
            euro.Image = "cl.png";
            euro.Award = "UEFA Champions League";
            euro.Amount = 5;
            euro.Season = "1976-77, 1977-78, 1980-81, 1983-84, 2004-05";
            euro.Type = "International";
            honours.Add(euro);

            Honour europaL = new Honour();
            europaL.Image = "el.png";
            europaL.Award = "UEFA Europa-League";
            europaL.Amount = 3;
            europaL.Season = "1972-73, 1975-76, 2000-01";
            europaL.Type = "International";
            honours.Add(europaL);

            Honour superCap = new Honour();
            superCap.Image = "sc.png";
            superCap.Award = "European Super Cup Winners";
            superCap.Amount = 3;
            superCap.Season = "1977, 2001, 2005";
            superCap.Type = "International";
            honours.Add(superCap);

            //create Managers
            var managers = new List<Manager>();
            Manager john = new Manager();
            john.Image = "McKenna.jpg";
            john.FirstName = "John";
            john.LastName = "McKenna";
            john.DOB = DateTime.Parse("1855/01/03");
            john.Nationality = "Ireland";
            john.Period = "1892-1896";
            managers.Add(john);

            Manager tom = new Manager();
            tom.Image = "Watson.jpg";
            tom.FirstName = "Tom";
            tom.LastName = "Watson";
            tom.DOB = DateTime.Parse("1859/04/09");
            tom.Nationality = "England";
            tom.Period = "1896-1915";
            managers.Add(tom);

            Manager david = new Manager();
            david.Image = "Ashworth.jpg";
            david.FirstName = "David";
            david.LastName = "Ashworth";
            david.DOB = DateTime.Parse("1868/01/01");
            david.Nationality = "Ireland";
            david.Period = "1919-1922";
            managers.Add(david);

            Manager matt = new Manager();
            matt.Image = "McQueen.jpg";
            matt.FirstName = "Matt";
            matt.LastName = "McQueen";
            matt.DOB = DateTime.Parse("1863/05/18");
            matt.Nationality = "England";
            matt.Period = "1923-1928";
            managers.Add(matt);

            Manager george = new Manager();
            george.Image = "Patterson.jpg";
            george.FirstName = "George";
            george.LastName = "Patterson";
            george.DOB = DateTime.Parse("1887/01/01");
            george.Nationality = "Scotland";
            george.Period = "1928-1936";
            managers.Add(george);

            Manager kay = new Manager();
            kay.Image = "Kay.jpg";
            kay.FirstName = "George";
            kay.LastName = "Kay";
            kay.DOB = DateTime.Parse("1891/09/21");
            kay.Nationality = "England";
            kay.Period = "1936-1951";
            managers.Add(kay);

            Manager don = new Manager();
            don.Image = "Welsh.jpg";
            don.FirstName = "Don";
            don.LastName = "Welsh";
            don.DOB = DateTime.Parse("1911/02/25");
            don.Nationality = "England";
            don.Period = "1951-1956";
            managers.Add(don);

            Manager phil = new Manager();
            phil.Image = "Taylor.jpg";
            phil.FirstName = "Phil";
            phil.LastName = "Taylor";
            phil.DOB = DateTime.Parse("1917/09/18");
            phil.Nationality = "England";
            phil.Period = "1956-1959";
            managers.Add(phil);

            Manager bill = new Manager();
            bill.Image = "Shankley.jpg";
            bill.FirstName = "Bill";
            bill.LastName = "Shankly";
            bill.DOB = DateTime.Parse("1913/09/02");
            bill.Nationality = "Scotland";
            bill.Period = "1959-1974";
            managers.Add(bill);

            Manager bob = new Manager();
            bob.Image = "Paisley.jpg";
            bob.FirstName = "Bob";
            bob.LastName = "Paisley";
            bob.DOB = DateTime.Parse("1919/01/23");
            bob.Nationality = "England";
            bob.Period = "1974-1983";
            managers.Add(bob);

            Manager fagan = new Manager();
            fagan.Image = "Fagan.jpg";
            fagan.FirstName = "Joe";
            fagan.LastName = "Fagan";
            fagan.DOB = DateTime.Parse("1921/03/12");
            fagan.Nationality = "England";
            fagan.Period = "1983-1985";
            managers.Add(fagan);

            Manager kenny = new Manager();
            kenny.Image = "Dalglish.jpg";
            kenny.FirstName = "Kenny";
            kenny.LastName = "Dalglish";
            kenny.DOB = DateTime.Parse("1951/03/04");
            kenny.Nationality = "Scotland";
            kenny.Period = "1985-1991";
            managers.Add(kenny);

            Manager souness = new Manager();
            souness.Image = "Souness.jpg";
            souness.FirstName = "Graeme";
            souness.LastName = "Souness";
            souness.DOB = DateTime.Parse("1953/05/06");
            souness.Nationality = "Scotland";
            souness.Period = "1991-1994";
            managers.Add(souness);

            Manager evans = new Manager();
            evans.Image = "Evans.jpg";
            evans.FirstName = "Roy";
            evans.LastName = "Evans";
            evans.DOB = DateTime.Parse("1948/10/04");
            evans.Nationality = "England";
            evans.Period = "1994-1998";
            managers.Add(evans);

            Manager houllier = new Manager();
            houllier.Image = "Houllier.jpg";
            houllier.FirstName = "Gerard";
            houllier.LastName = "Houllier";
            houllier.DOB = DateTime.Parse("1947/09/03");
            houllier.Nationality = "France";
            houllier.Period = "1998-2004";
            managers.Add(houllier); 
            
            Manager rafa = new Manager();
            rafa.Image = "Benitez.jpg";
            rafa.FirstName = "Rafael";
            rafa.LastName = "Benitez";
            rafa.DOB = DateTime.Parse("1960/04/16");
            rafa.Nationality = "Spain";
            rafa.Period = "2004-2010";
            managers.Add(rafa);

            Manager hodgson = new Manager();
            hodgson.Image = "Hodgson.jpg";
            hodgson.FirstName = "Roy";
            hodgson.LastName = "Hodgson";
            hodgson.DOB = DateTime.Parse("1947/08/09");
            hodgson.Nationality = "England";
            hodgson.Period = "2010-2011";
            managers.Add(hodgson);

            Manager kennyTwo = new Manager();
            kennyTwo.Image = "DalglishTwo.jpg";
            kennyTwo.FirstName = "Kenny";
            kennyTwo.LastName = "Dalglish";
            kennyTwo.DOB = DateTime.Parse("1951/03/04");
            kennyTwo.Nationality = "Scotland";
            kennyTwo.Period = "2011-2012";
            managers.Add(kennyTwo);

            Manager rodgers = new Manager();
            rodgers.Image = "Rodgers.jpg";
            rodgers.FirstName = "Brendan";
            rodgers.LastName = "Rodgers";
            rodgers.DOB = DateTime.Parse("1973/01/26");
            rodgers.Nationality = "Northern Ireland";
            rodgers.Period = "2012-2015";
            managers.Add(rodgers);

            Manager klopp = new Manager();
            klopp.Image = "Klopp.jpeg";
            klopp.FirstName = "Jurgen";
            klopp.LastName = "Klopp";
            klopp.DOB = DateTime.Parse("1967/06/16");
            klopp.Nationality = "Germany";
            klopp.Period = "2015-Present";
            managers.Add(klopp);


          

            epl.Fixtures = fixtures;
            /*fa.Fixtures = fixtures;
            capital.Fixtures = fixtures;
            europa.Fixtures = fixtures;
            friendly.Fixtures = fixtures;*/

            player.Fixtures = fixtures;

            fixture.Players = players;
            fixtureTwo.Players = players;
            fixtureThree.Players = players;
            fixtureFour.Players = players;
            fixtureFive.Players = players;
            fixtureSix.Players = players;

            john.Honours = honours;
            league.Managers = managers;

            gk.Players = players;
            /*rb.Players = players;
            cb.Players = players;
            lb.Players = players;
            rm.Players = players;
            ram.Players = players;
            cdm.Players = players;
            cm.Players = players;
            cam.Players = players;
            lam.Players = players;
            lm.Players = players;
            rw.Players = players;
            lw.Players = players;
            cf.Players = players;
            st.Players = players;*/

            lfc.Players = players;
            //lfc21.Players = players;


            foreach (var c in competitions)
            {
                context.Competitions.Add(c);
            }

            foreach (var po in positions)
            {
                context.PlayerPositions.Add(po);
            }

            foreach (var t in teams)
            {
                context.Teams.Add(t);
            }

            foreach (var p in players)
            {
                context.Players.Add(p);
            }

            foreach (var f in fixtures)
            {
                context.Fixtures.Add(f);
            }

            foreach (var h in honours)
            {
                context.Honours.Add(h);
            }

            foreach (var m in managers)
            {
                context.Managers.Add(m);
            }

            context.SaveChanges();
        }
    }
}