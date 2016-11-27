using DAL.Models;
using DAL.Models.Lookup;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace HackathonVZ.Data
{
    public static class ApplicationDbContextSeedData
    {
        public static void SeedData(this IServiceScopeFactory scopeFactory)
        {
            using (var serviceScope = scopeFactory.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                #region Countries

                if (!context.Country.Any())
                {
                    context.Country.AddRangeAsync(
                    new Country { Name = "Afghanistan", Abrv = "AF" },
                    new Country { Name = "Albania", Abrv = "AL" },
                    new Country { Name = "Algeria", Abrv = "DZ" },
                    new Country { Name = "American Samoa", Abrv = "AS" },
                    new Country { Name = "Andorra", Abrv = "AD" },
                    new Country { Name = "Angola", Abrv = "AO" },
                    new Country { Name = "Anguilla", Abrv = "AI" },
                    new Country { Name = "Antarctica", Abrv = "AQ" },
                    new Country { Name = "Antigua and Barbuda", Abrv = "AG" },
                    new Country { Name = "Argentina", Abrv = "AR" },
                    new Country { Name = "Armenia", Abrv = "AM" },
                    new Country { Name = "Aruba", Abrv = "AW" },
                    new Country { Name = "Australia", Abrv = "AU" },
                    new Country { Name = "Austria", Abrv = "AT" },
                    new Country { Name = "Azerbaijan", Abrv = "AZ" },
                    new Country { Name = "Bahamas", Abrv = "BS" },
                    new Country { Name = "Bahrain", Abrv = "BH" },
                    new Country { Name = "Bangladesh", Abrv = "BD" },
                    new Country { Name = "Barbados", Abrv = "BB" },
                    new Country { Name = "Belarus", Abrv = "BY" },
                    new Country { Name = "Belgium", Abrv = "BE" },
                    new Country { Name = "Belize", Abrv = "BZ" },
                    new Country { Name = "Benin", Abrv = "BJ" },
                    new Country { Name = "Bermuda", Abrv = "BM" },
                    new Country { Name = "Bhutan", Abrv = "BT" },
                    new Country { Name = "Bolivia", Abrv = "BO" },
                    new Country { Name = "Bosnia and Herzegovina", Abrv = "BA" },
                    new Country { Name = "Botswana", Abrv = "BW" },
                    new Country { Name = "Bouvet Island", Abrv = "BV" },
                    new Country { Name = "Brazil", Abrv = "BR" },
                    new Country { Name = "British Indian Ocean Territory", Abrv = "IO" },
                    new Country { Name = "Brunei Darussalam", Abrv = "BN" },
                    new Country { Name = "Bulgaria", Abrv = "BG" },
                    new Country { Name = "Burkina Faso", Abrv = "BF" },
                    new Country { Name = "Burundi", Abrv = "BI" },
                    new Country { Name = "Cambodia", Abrv = "KH" },
                    new Country { Name = "Cameroon", Abrv = "CM" },
                    new Country { Name = "Canada", Abrv = "CA" },
                    new Country { Name = "Cape Verde", Abrv = "CV" },
                    new Country { Name = "Cayman Islands", Abrv = "KY" },
                    new Country { Name = "Central African Republic", Abrv = "CF" },
                    new Country { Name = "Chad", Abrv = "TD" },
                    new Country { Name = "Chile", Abrv = "CL" },
                    new Country { Name = "China", Abrv = "CN" },
                    new Country { Name = "Christmas Island", Abrv = "CX" },
                    new Country { Name = "Cocos (Keeling) Islands", Abrv = "CC" },
                    new Country { Name = "Colombia", Abrv = "CO" },
                    new Country { Name = "Comoros", Abrv = "KM" },
                    new Country { Name = "Congo", Abrv = "CG" },
                    new Country { Name = "Congo, the Democratic Republic of the", Abrv = "CD" },
                    new Country { Name = "Cook Islands", Abrv = "CK" },
                    new Country { Name = "Costa Rica", Abrv = "CR" },
                    new Country { Name = "Cote D'Ivoire", Abrv = "CI" },
                    new Country { Name = "Croatia", Abrv = "HR" },
                    new Country { Name = "Cuba", Abrv = "CU" },
                    new Country { Name = "Cyprus", Abrv = "CY" },
                    new Country { Name = "Czech Republic", Abrv = "CZ" },
                    new Country { Name = "Denmark", Abrv = "DK" },
                    new Country { Name = "Djibouti", Abrv = "DJ" },
                    new Country { Name = "Dominica", Abrv = "DM" },
                    new Country { Name = "Dominican Republic", Abrv = "DO" },
                    new Country { Name = "Ecuador", Abrv = "EC" },
                    new Country { Name = "Egypt", Abrv = "EG" },
                    new Country { Name = "El Salvador", Abrv = "SV" },
                    new Country { Name = "Equatorial Guinea", Abrv = "GQ" },
                    new Country { Name = "Eritrea", Abrv = "ER" },
                    new Country { Name = "Estonia", Abrv = "EE" },
                    new Country { Name = "Ethiopia", Abrv = "ET" },
                    new Country { Name = "Falkland Islands (Malvinas)", Abrv = "FK" },
                    new Country { Name = "Faroe Islands", Abrv = "FO" },
                    new Country { Name = "Fiji", Abrv = "FJ" },
                    new Country { Name = "Finland", Abrv = "FI" },
                    new Country { Name = "France", Abrv = "FR" },
                    new Country { Name = "French Guiana", Abrv = "GF" },
                    new Country { Name = "French Polynesia", Abrv = "PF" },
                    new Country { Name = "French Southern Territories", Abrv = "TF" },
                    new Country { Name = "Gabon", Abrv = "GA" },
                    new Country { Name = "Gambia", Abrv = "GM" },
                    new Country { Name = "Georgia", Abrv = "GE" },
                    new Country { Name = "Germany", Abrv = "DE" },
                    new Country { Name = "Ghana", Abrv = "GH" },
                    new Country { Name = "Gibraltar", Abrv = "GI" },
                    new Country { Name = "Greece", Abrv = "GR" },
                    new Country { Name = "Greenland", Abrv = "GL" },
                    new Country { Name = "Grenada", Abrv = "GD" },
                    new Country { Name = "Guadeloupe", Abrv = "GP" },
                    new Country { Name = "Guam", Abrv = "GU" },
                    new Country { Name = "Guatemala", Abrv = "GT" },
                    new Country { Name = "Guinea", Abrv = "GN" },
                    new Country { Name = "Guinea-Bissau", Abrv = "GW" },
                    new Country { Name = "Guyana", Abrv = "GY" },
                    new Country { Name = "Haiti", Abrv = "HT" },
                    new Country { Name = "Heard Island and Mcdonald Islands", Abrv = "HM" },
                    new Country { Name = "Holy See (Vatican City State)", Abrv = "VA" },
                    new Country { Name = "Honduras", Abrv = "HN" },
                    new Country { Name = "Hong Kong", Abrv = "HK" },
                    new Country { Name = "Hungary", Abrv = "HU" },
                    new Country { Name = "Iceland", Abrv = "IS" },
                    new Country { Name = "India", Abrv = "IN" },
                    new Country { Name = "Indonesia", Abrv = "ID" },
                    new Country { Name = "Iran, Islamic Republic of", Abrv = "IR" },
                    new Country { Name = "Iraq", Abrv = "IQ" },
                    new Country { Name = "Ireland", Abrv = "IE" },
                    new Country { Name = "Israel", Abrv = "IL" },
                    new Country { Name = "Italy", Abrv = "IT" },
                    new Country { Name = "Jamaica", Abrv = "JM" },
                    new Country { Name = "Japan", Abrv = "JP" },
                    new Country { Name = "Jordan", Abrv = "JO" },
                    new Country { Name = "Kazakhstan", Abrv = "KZ" },
                    new Country { Name = "Kenya", Abrv = "KE" },
                    new Country { Name = "Kiribati", Abrv = "KI" },
                    new Country { Name = "Korea, Democratic People's Republic of", Abrv = "KP" },
                    new Country { Name = "Korea, Republic of", Abrv = "KR" },
                    new Country { Name = "Kuwait", Abrv = "KW" },
                    new Country { Name = "Kyrgyzstan", Abrv = "KG" },
                    new Country { Name = "Lao People's Democratic Republic", Abrv = "LA" },
                    new Country { Name = "Latvia", Abrv = "LV" },
                    new Country { Name = "Lebanon", Abrv = "LB" },
                    new Country { Name = "Lesotho", Abrv = "LS" },
                    new Country { Name = "Liberia", Abrv = "LR" },
                    new Country { Name = "Libyan Arab Jamahiriya", Abrv = "LY" },
                    new Country { Name = "Liechtenstein", Abrv = "LI" },
                    new Country { Name = "Lithuania", Abrv = "LT" },
                    new Country { Name = "Luxembourg", Abrv = "LU" },
                    new Country { Name = "Macao", Abrv = "MO" },
                    new Country { Name = "Macedonia, the Former Yugoslav Republic of", Abrv = "MK" },
                    new Country { Name = "Madagascar", Abrv = "MG" },
                    new Country { Name = "Malawi", Abrv = "MW" },
                    new Country { Name = "Malaysia", Abrv = "MY" },
                    new Country { Name = "Maldives", Abrv = "MV" },
                    new Country { Name = "Mali", Abrv = "ML" },
                    new Country { Name = "Malta", Abrv = "MT" },
                    new Country { Name = "Marshall Islands", Abrv = "MH" },
                    new Country { Name = "Martinique", Abrv = "MQ" },
                    new Country { Name = "Mauritania", Abrv = "MR" },
                    new Country { Name = "Mauritius", Abrv = "MU" },
                    new Country { Name = "Mayotte", Abrv = "YT" },
                    new Country { Name = "Mexico", Abrv = "MX" },
                    new Country { Name = "Micronesia, Federated States of", Abrv = "FM" },
                    new Country { Name = "Moldova, Republic of", Abrv = "MD" },
                    new Country { Name = "Monaco", Abrv = "MC" },
                    new Country { Name = "Mongolia", Abrv = "MN" },
                    new Country { Name = "Montenegro", Abrv = "ME" },
                    new Country { Name = "Montserrat", Abrv = "MS" },
                    new Country { Name = "Morocco", Abrv = "MA" },
                    new Country { Name = "Mozambique", Abrv = "MZ" },
                    new Country { Name = "Myanmar", Abrv = "MM" },
                    new Country { Name = "Namibia", Abrv = "NA" },
                    new Country { Name = "Nauru", Abrv = "NR" },
                    new Country { Name = "Nepal", Abrv = "NP" },
                    new Country { Name = "Netherlands", Abrv = "NL" },
                    new Country { Name = "Netherlands Antilles", Abrv = "AN" },
                    new Country { Name = "New Caledonia", Abrv = "NC" },
                    new Country { Name = "New Zealand", Abrv = "NZ" },
                    new Country { Name = "Nicaragua", Abrv = "NI" },
                    new Country { Name = "Niger", Abrv = "NE" },
                    new Country { Name = "Nigeria", Abrv = "NG" },
                    new Country { Name = "Niue", Abrv = "NU" },
                    new Country { Name = "Norfolk Island", Abrv = "NF" },
                    new Country { Name = "Northern Mariana Islands", Abrv = "MP" },
                    new Country { Name = "Norway", Abrv = "NO" },
                    new Country { Name = "Oman", Abrv = "OM" },
                    new Country { Name = "Pakistan", Abrv = "PK" },
                    new Country { Name = "Palau", Abrv = "PW" },
                    new Country { Name = "Palestinian Territory, Occupied", Abrv = "PS" },
                    new Country { Name = "Panama", Abrv = "PA" },
                    new Country { Name = "Papua New Guinea", Abrv = "PG" },
                    new Country { Name = "Paraguay", Abrv = "PY" },
                    new Country { Name = "Peru", Abrv = "PE" },
                    new Country { Name = "Philippines", Abrv = "PH" },
                    new Country { Name = "Pitcairn", Abrv = "PN" },
                    new Country { Name = "Poland", Abrv = "PL" },
                    new Country { Name = "Portugal", Abrv = "PT" },
                    new Country { Name = "Puerto Rico", Abrv = "PR" },
                    new Country { Name = "Qatar", Abrv = "QA" },
                    new Country { Name = "Reunion", Abrv = "RE" },
                    new Country { Name = "Romania", Abrv = "RO" },
                    new Country { Name = "Russian Federation", Abrv = "RU" },
                    new Country { Name = "Rwanda", Abrv = "RW" },
                    new Country { Name = "Saint Helena", Abrv = "SH" },
                    new Country { Name = "Saint Kitts and Nevis", Abrv = "KN" },
                    new Country { Name = "Saint Lucia", Abrv = "LC" },
                    new Country { Name = "Saint Pierre and Miquelon", Abrv = "PM" },
                    new Country { Name = "Saint Vincent and the Grenadines", Abrv = "VC" },
                    new Country { Name = "Samoa", Abrv = "WS" },
                    new Country { Name = "San Marino", Abrv = "SM" },
                    new Country { Name = "Sao Tome and Principe", Abrv = "ST" },
                    new Country { Name = "Saudi Arabia", Abrv = "SA" },
                    new Country { Name = "Senegal", Abrv = "SN" },
                    new Country { Name = "Serbia", Abrv = "CS" },
                    new Country { Name = "Seychelles", Abrv = "SC" },
                    new Country { Name = "Sierra Leone", Abrv = "SL" },
                    new Country { Name = "Singapore", Abrv = "SG" },
                    new Country { Name = "Slovakia", Abrv = "SK" },
                    new Country { Name = "Slovenia", Abrv = "SI" },
                    new Country { Name = "Solomon Islands", Abrv = "SB" },
                    new Country { Name = "Somalia", Abrv = "SO" },
                    new Country { Name = "South Africa", Abrv = "ZA" },
                    new Country { Name = "South Georgia and the South Sandwich Islands", Abrv = "GS" },
                    new Country { Name = "Spain", Abrv = "ES" },
                    new Country { Name = "Sri Lanka", Abrv = "LK" },
                    new Country { Name = "Sudan", Abrv = "SD" },
                    new Country { Name = "Suriname", Abrv = "SR" },
                    new Country { Name = "Svalbard and Jan Mayen", Abrv = "SJ" },
                    new Country { Name = "Swaziland", Abrv = "SZ" },
                    new Country { Name = "Sweden", Abrv = "SE" },
                    new Country { Name = "Switzerland", Abrv = "CH" },
                    new Country { Name = "Syrian Arab Republic", Abrv = "SY" },
                    new Country { Name = "Taiwan Province of China", Abrv = "TW" },
                    new Country { Name = "Tajikistan", Abrv = "TJ" },
                    new Country { Name = "Tanzania United Republic of", Abrv = "TZ" },
                    new Country { Name = "Thailand", Abrv = "TH" },
                    new Country { Name = "Timor-Leste", Abrv = "TL" },
                    new Country { Name = "Togo", Abrv = "TG" },
                    new Country { Name = "Tokelau", Abrv = "TK" },
                    new Country { Name = "Tonga", Abrv = "TO" },
                    new Country { Name = "Trinidad and Tobago", Abrv = "TT" },
                    new Country { Name = "Tunisia", Abrv = "TN" },
                    new Country { Name = "Turkey", Abrv = "TR" },
                    new Country { Name = "Turkmenistan", Abrv = "TM" },
                    new Country { Name = "Turks and Caicos Islands", Abrv = "TC" },
                    new Country { Name = "Tuvalu", Abrv = "TV" },
                    new Country { Name = "Uganda", Abrv = "UG" },
                    new Country { Name = "Ukraine", Abrv = "UA" },
                    new Country { Name = "United Arab Emirates", Abrv = "AE" },
                    new Country { Name = "United Kingdom", Abrv = "GB" },
                    new Country { Name = "United States", Abrv = "US" },
                    new Country { Name = "United States Minor Outlying Islands", Abrv = "UM" },
                    new Country { Name = "Uruguay", Abrv = "UY" },
                    new Country { Name = "Uzbekistan", Abrv = "UZ" },
                    new Country { Name = "Vanuatu", Abrv = "VU" },
                    new Country { Name = "Venezuela", Abrv = "VE" },
                    new Country { Name = "Viet Nam", Abrv = "VN" },
                    new Country { Name = "Virgin Islands British", Abrv = "VG" },
                    new Country { Name = "Virgin Islands US", Abrv = "VI" },
                    new Country { Name = "Wallis and Futuna", Abrv = "WF" },
                    new Country { Name = "Western Sahara", Abrv = "EH" },
                    new Country { Name = "Yemen", Abrv = "YE" },
                    new Country { Name = "Zambia", Abrv = "ZM" },
                    new Country { Name = "Zimbabwe", Abrv = "ZW" }
                    );
                }

                #endregion Countries

                #region Categories

                if (!context.Category.Any())
                {
                    context.Category.AddRangeAsync(
                        new Category { Name = "Movie", Abrv = "MOV" },
                        new Category { Name = "History", Abrv = "HIS" },
                        new Category { Name = "Science", Abrv = "SCI" },
                        new Category { Name = "Music", Abrv = "MUS" },
                        new Category { Name = "Literature", Abrv = "LIT" },
                        new Category { Name = "Geography", Abrv = "GEO" },
                        new Category { Name = "Sport", Abrv = "SPRT" }
                    );
                }

                #endregion Categories

                #region QuestionTypes

                if (!context.QuestionType.Any())
                {
                    context.QuestionType.AddRangeAsync(
                        new QuestionType { Name = "Single Answer", Abrv = "1AN", TimerSeconds = 10 },
                        new QuestionType { Name = "Multiple Answer", Abrv = "XAN", TimerSeconds = 20 },
                        new QuestionType { Name = "Custom Input", Abrv = "CUS", TimerSeconds = 100 },
                        new QuestionType { Name = "Mixed", Abrv = "MIX", TimerSeconds = 10910 }
                    );
                }

                #endregion QuestionTypes

                #region Modifiers

                if (!context.Modifier.Any())
                {
                    context.Modifier.AddRangeAsync(
                        new Modifier { Name = "Right to left", Abrv = "RTL" },
                        new Modifier { Name = "Low opacity", Abrv = "LWOP" },
                        new Modifier { Name = "Hide letters", Abrv = "HIDE" }
                    );
                }

                #endregion Modifiers

                #region Questions

                if (!context.Question.Any())
                {
                    context.Question.AddRangeAsync(
                        new Question { CategoryId = 1, TypeId = 1, QuestionText = "What was the name of The Lone Ranger's horse?" },
                        new Question { CategoryId = 1, TypeId = 1, QuestionText = "What is the name of Mickey Mouse's dog?" },
                        new Question { CategoryId = 1, TypeId = 1, QuestionText = "BB-8 is an astromech droid from what film?" },
                        new Question { CategoryId = 1, TypeId = 2, QuestionText = "Name the three tunnels in the movie The Great Escape?" },
                        new Question { CategoryId = 1, TypeId = 2, QuestionText = "Name the 2 protagonists in Lethal Weapon?" },
                        new Question { CategoryId = 1, TypeId = 2, QuestionText = "What items does Bilbo give to Frodo in the Lord of the rings? " },
                        new Question { CategoryId = 1, TypeId = 4, QuestionText = "What Star Wars actress had an early role in Leon: The Professional?" },
                        new Question { CategoryId = 1, TypeId = 4, QuestionText = "Who played Dracula in the 1931 vampire-horror film Dracula?  " },
                        new Question { CategoryId = 1, TypeId = 4, QuestionText = "Who directed Raging Bull?" },
                        new Question { CategoryId = 2, TypeId = 1, QuestionText = "Bahamas gained independence in 1973 from what country? " },
                        new Question { CategoryId = 2, TypeId = 1, QuestionText = "Who was the first Tudor Monarch in England? " },
                        new Question { CategoryId = 2, TypeId = 2, QuestionText = "What royal Houses fought in the war of the roses?" },
                        new Question { CategoryId = 2, TypeId = 2, QuestionText = "What are the first names of both the Wright brothers?" },
                        new Question { CategoryId = 2, TypeId = 4, QuestionText = "In what year was the Declaration of Independence created?" },
                        new Question { CategoryId = 2, TypeId = 4, QuestionText = "In what year was the fisrt modern Olympic Games held?" },
                        new Question { CategoryId = 3, TypeId = 1, QuestionText = "What is the common name of the minerals jadeite or nephrite?" },
                        new Question { CategoryId = 3, TypeId = 1, QuestionText = "What is the largest internal organ of the human body?" },
                        new Question { CategoryId = 3, TypeId = 2, QuestionText = "Which of these are Moons of Jupiter" },
                        new Question { CategoryId = 3, TypeId = 2, QuestionText = "Which two elements are liquid at room temperature?" },
                        new Question { CategoryId = 3, TypeId = 4, QuestionText = "Who came up with the three laws of motion" },
                        new Question { CategoryId = 3, TypeId = 4, QuestionText = "Who designed and built the Pascaline?" },
                        new Question { CategoryId = 4, TypeId = 1, QuestionText = "Hallelujah is a song written by which Canadian recording artist?" },
                        new Question { CategoryId = 4, TypeId = 1, QuestionText = "Who sang All Shook Up in 1957?" },
                        new Question { CategoryId = 4, TypeId = 2, QuestionText = "Identify Michael Jackson albums?" },
                        new Question { CategoryId = 4, TypeId = 2, QuestionText = "Identify albums released by Pink Floyd?" },
                        new Question { CategoryId = 4, TypeId = 4, QuestionText = "What was the name of Taylor Swift's first album?" },
                        new Question { CategoryId = 4, TypeId = 4, QuestionText = "What song by Michael Jackson contains the lyrics Annie are you OK ?" },
                        new Question { CategoryId = 5, TypeId = 1, QuestionText = "What musical instrument did Sherlock Holmes play?" },
                        new Question { CategoryId = 5, TypeId = 1, QuestionText = "I think, therefore I am, is a phrase by which philospher?" },
                        new Question { CategoryId = 5, TypeId = 2, QuestionText = "In the book 1984 the party has 3 slogans, what are they? " },
                        new Question { CategoryId = 5, TypeId = 2, QuestionText = "What are the 3 Deathly Hallows in Harry Potter?" },
                        new Question { CategoryId = 5, TypeId = 4, QuestionText = "Who won the Nobel Prize for Literature in 2016?" },
                        new Question { CategoryId = 5, TypeId = 4, QuestionText = "How many letters are in the modern English alphabet?" },
                        new Question { CategoryId = 6, TypeId = 1, QuestionText = "Portugal is bordered by what other country?" },
                        new Question { CategoryId = 6, TypeId = 1, QuestionText = "The Giza Plateau can be found in what country" },
                        new Question { CategoryId = 6, TypeId = 1, QuestionText = "In which country is the Taj Mahal?" },
                        new Question { CategoryId = 6, TypeId = 2, QuestionText = "Which 2 of these states border with the Pacific Ocean?" },
                        new Question { CategoryId = 6, TypeId = 2, QuestionText = "Name 2 of the highest mountains in Austria? " },
                        new Question { CategoryId = 6, TypeId = 4, QuestionText = "Which ocean trench is the deepest?" },
                        new Question { CategoryId = 6, TypeId = 4, QuestionText = "What is the capital city of Australia?" },
                        new Question { CategoryId = 7, TypeId = 1, QuestionText = "Shaquille O'Neal retired in 2011 from what sport?" },
                        new Question { CategoryId = 7, TypeId = 1, QuestionText = "Tiger Woods became a professional golfer in what year?" },
                        new Question { CategoryId = 7, TypeId = 2, QuestionText = "Who played in the 2014 FIFA world cup finals?" },
                        new Question { CategoryId = 7, TypeId = 2, QuestionText = "Who played in the 2010 FIFA world cup finals" },
                        new Question { CategoryId = 7, TypeId = 4, QuestionText = "Where did the sport of curling originate" },
                        new Question { CategoryId = 7, TypeId = 4, QuestionText = "In what country did table tennis originate" }
                    );
                }

                #endregion Questions

                #region Teams

                if (!context.Team.Any())
                {
                    context.Team.AddRangeAsync(
                        new Team { Name = "FFOS" },
                        new Team { Name = "FERIT" }
                    );
                }

                #endregion Teams

                #region Answers

                if (!context.Answer.Any())
                {
                    //context.Answer.AddRangeAsync(
                    //    new Answer { QuestionId = 1, Correct = true, AnswerText = "Silver" },
                    //    new Answer { QuestionId = 1, AnswerText = "Shadow" },
                    //    new Answer { QuestionId = 1, AnswerText = "Big John" },
                    //    new Answer { QuestionId = 1, AnswerText = "Diablo" },
                    //    new Answer { QuestionId = 2, Correct = true, AnswerText = "Pluto" },
                    //    new Answer { QuestionId = 2, AnswerText = "Spot" },
                    //    new Answer { QuestionId = 2, AnswerText = "Buddy" },
                    //    new Answer { QuestionId = 2, AnswerText = "Plato" },
                    //    new Answer { QuestionId = 3, Correct = true, AnswerText = "Star Wars" },
                    //    new Answer { QuestionId = 3, AnswerText = "Star Trek" },
                    //    new Answer { QuestionId = 3, AnswerText = "Alien" },
                    //    new Answer { QuestionId = 3, AnswerText = "Interstellar" },
                    //    new Answer { QuestionId = 4, Correct = true, AnswerText = "Tom" },
                    //    new Answer { QuestionId = 4, Correct = true, AnswerText = "Dick" },
                    //    new Answer { QuestionId = 4, Correct = true, AnswerText = "Harry" },
                    //    new Answer { QuestionId = 4, AnswerText = "John" },
                    //    new Answer { QuestionId = 5, Correct = true, AnswerText = "Roger Murtaugh" },
                    //    new Answer { QuestionId = 5, Correct = true, AnswerText = "Martin Riggs" },
                    //    new Answer { QuestionId = 5, AnswerText = "Ray Tango" },
                    //    new Answer { QuestionId = 5, AnswerText = "Gabe Cash" },
                    //    new Answer { QuestionId = 6, Correct = true, AnswerText = "Sting" },
                    //    new Answer { QuestionId = 6, Correct = true, AnswerText = "Mithril shirt" },
                    //    new Answer { QuestionId = 6, AnswerText = "Staff" },
                    //    new Answer { QuestionId = 6, AnswerText = "Shoes" },
                    //    new Answer { QuestionId = 7, Correct = true, AnswerText = "Great Britain" },
                    //    new Answer { QuestionId = 7, AnswerText = "Spain" },
                    //    new Answer { QuestionId = 7, AnswerText = "France" },
                    //    new Answer { QuestionId = 7, AnswerText = "Germany" },
                    //    new Answer { QuestionId = 8, Correct = true, AnswerText = "Henry VII" },
                    //    new Answer { QuestionId = 8, AnswerText = "Edward VII" },
                    //    new Answer { QuestionId = 8, AnswerText = "William the Conqueror" },
                    //    new Answer { QuestionId = 8, AnswerText = "Henry VII" },
                    //    new Answer { QuestionId = 9, Correct = true, AnswerText = "Plantagenet" },
                    //    new Answer { QuestionId = 9, Correct = true, AnswerText = "Lancaster" },
                    //    new Answer { QuestionId = 9, Correct = true, AnswerText = "York" },
                    //    new Answer { QuestionId = 9, AnswerText = "Lannister" },
                    //    new Answer { QuestionId = 10, Correct = true, AnswerText = "Orville" },
                    //    new Answer { QuestionId = 10, Correct = true, AnswerText = "Wilbur" },
                    //    new Answer { QuestionId = 10, AnswerText = "Milton" },
                    //    new Answer { QuestionId = 10, AnswerText = "Charles" },
                    //    new Answer { QuestionId = 11, Correct = true, AnswerText = "Jade" },
                    //    new Answer { QuestionId = 11, AnswerText = "Saphire" },
                    //    new Answer { QuestionId = 11, AnswerText = "Slate" },
                    //    new Answer { QuestionId = 11, AnswerText = "Agate" },
                    //    new Answer { QuestionId = 12, Correct = true, AnswerText = "Liver" },
                    //    new Answer { QuestionId = 12, AnswerText = "Heart" },
                    //    new Answer { QuestionId = 12, AnswerText = "Brain" },
                    //    new Answer { QuestionId = 12, AnswerText = "Skin" },
                    //    new Answer { QuestionId = 13, Correct = true, AnswerText = "Europa" },
                    //    new Answer { QuestionId = 13, Correct = true, AnswerText = "Callisto" },
                    //    new Answer { QuestionId = 13, AnswerText = "Phobos" },
                    //    new Answer { QuestionId = 13, AnswerText = "Deimos" },
                    //    new Answer { QuestionId = 14, Correct = true, AnswerText = "Mercury" },
                    //    new Answer { QuestionId = 14, Correct = true, AnswerText = "Bromine" },
                    //    new Answer { QuestionId = 14, AnswerText = "Gallium" },
                    //    new Answer { QuestionId = 14, AnswerText = "Iron" },
                    //    new Answer { QuestionId = 15, Correct = true, AnswerText = "Leonard Cohen" },
                    //    new Answer { QuestionId = 15, AnswerText = "Justin Bieber" },
                    //    new Answer { QuestionId = 15, AnswerText = "Celine Dion" },
                    //    new Answer { QuestionId = 15, AnswerText = "Gordon Downie" },
                    //    new Answer { QuestionId = 16, Correct = true, AnswerText = "Elvis Presley" },
                    //    new Answer { QuestionId = 16, AnswerText = "Frank Sinatra" },
                    //    new Answer { QuestionId = 16, AnswerText = "Dean Martin" },
                    //    new Answer { QuestionId = 16, AnswerText = "Chuck Berry" },
                    //    new Answer { QuestionId = 17, Correct = true, AnswerText = "Thriller" },
                    //    new Answer { QuestionId = 17, Correct = true, AnswerText = "Ben" },
                    //    new Answer { QuestionId = 17, AnswerText = "King of Rock" },
                    //    new Answer { QuestionId = 17, AnswerText = "Mike" },
                    //    new Answer { QuestionId = 18, Correct = true, AnswerText = "The Wall" },
                    //    new Answer { QuestionId = 18, Correct = true, AnswerText = "Animals" },
                    //    new Answer { QuestionId = 18, AnswerText = "Wish I was here" },
                    //    new Answer { QuestionId = 18, AnswerText = "The Bell" },
                    //    new Answer { QuestionId = 19, Correct = true, AnswerText = "Violin" },
                    //    new Answer { QuestionId = 19, AnswerText = "Piano" },
                    //    new Answer { QuestionId = 19, AnswerText = "None" },
                    //    new Answer { QuestionId = 19, AnswerText = "Tuba" },
                    //    new Answer { QuestionId = 20, Correct = true, AnswerText = "Rene Descartes" },
                    //    new Answer { QuestionId = 20, AnswerText = "Aristotel" },
                    //    new Answer { QuestionId = 20, AnswerText = "Socrates" },
                    //    new Answer { QuestionId = 20, AnswerText = "Plato" },
                    //    new Answer { QuestionId = 21, Correct = true, AnswerText = "War is peace" },
                    //    new Answer { QuestionId = 21, Correct = true, AnswerText = "Freedom is slavery" },
                    //    new Answer { QuestionId = 21, Correct = true, AnswerText = "Ignorance is strength" },
                    //    new Answer { QuestionId = 21, AnswerText = "Solitude is company" },
                    //    new Answer { QuestionId = 22, Correct = true, AnswerText = "the elder wand" },
                    //    new Answer { QuestionId = 22, Correct = true, AnswerText = "invisibility cloak" },
                    //    new Answer { QuestionId = 22, Correct = true, AnswerText = "resurrection stone" },
                    //    new Answer { QuestionId = 22, AnswerText = "philosopher's stone" },
                    //    new Answer { QuestionId = 23, Correct = true, AnswerText = "Spain" },
                    //    new Answer { QuestionId = 23, AnswerText = "France" },
                    //    new Answer { QuestionId = 23, AnswerText = "Germany" },
                    //    new Answer { QuestionId = 23, AnswerText = "Croatia" },
                    //    new Answer { QuestionId = 24, Correct = true, AnswerText = "Egypt" },
                    //    new Answer { QuestionId = 24, AnswerText = "Syria" },
                    //    new Answer { QuestionId = 24, AnswerText = "Iraq" },
                    //    new Answer { QuestionId = 24, AnswerText = "Iran" },
                    //    new Answer { QuestionId = 25, Correct = true, AnswerText = "India" },
                    //    new Answer { QuestionId = 25, AnswerText = "Iraq" },
                    //    new Answer { QuestionId = 25, AnswerText = "Indonesia" },
                    //    new Answer { QuestionId = 25, AnswerText = "China" },
                    //    new Answer { QuestionId = 26, Correct = true, AnswerText = "Hawaii" },
                    //    new Answer { QuestionId = 26, Correct = true, AnswerText = "California" },
                    //    new Answer { QuestionId = 26, AnswerText = "Texas" },
                    //    new Answer { QuestionId = 26, AnswerText = "New York" },
                    //    new Answer { QuestionId = 27, Correct = true, AnswerText = "Grossglockner" },
                    //    new Answer { QuestionId = 27, Correct = true, AnswerText = "Wildspitze" },
                    //    new Answer { QuestionId = 27, AnswerText = "Weisskugel" },
                    //    new Answer { QuestionId = 27, AnswerText = "Glocknerwand" },
                    //    new Answer { QuestionId = 28, Correct = true, AnswerText = "Basketball" },
                    //    new Answer { QuestionId = 28, AnswerText = "Golf" },
                    //    new Answer { QuestionId = 28, AnswerText = "Swimming" },
                    //    new Answer { QuestionId = 28, AnswerText = "Football" },
                    //    new Answer { QuestionId = 29, Correct = true, AnswerText = "1996" },
                    //    new Answer { QuestionId = 29, AnswerText = "1997" },
                    //    new Answer { QuestionId = 29, AnswerText = "1998" },
                    //    new Answer { QuestionId = 29, AnswerText = "1999" },
                    //    new Answer { QuestionId = 30, Correct = true, AnswerText = "Germany" },
                    //    new Answer { QuestionId = 30, Correct = true, AnswerText = "Argentina" },
                    //    new Answer { QuestionId = 30, AnswerText = "Spain" },
                    //    new Answer { QuestionId = 30, AnswerText = "Brazil" },
                    //    new Answer { QuestionId = 31, Correct = true, AnswerText = "Spain" },
                    //    new Answer { QuestionId = 31, Correct = true, AnswerText = "Netherlands" },
                    //    new Answer { QuestionId = 31, AnswerText = "Brazil" },
                    //    new Answer { QuestionId = 31, AnswerText = "Germany" }
                    //);
                }

                #endregion Answers

                #region Roles

                //if (!context.Roles.Any())
                //{
                //    context.Roles.AddRangeAsync(
                //        new Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole {  Name = "FFOS" },
                //        new Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole { Name = "FERIT" }
                //    );
                //}

                #endregion Roles

                context.SaveChanges();
            }
        }
    }
}