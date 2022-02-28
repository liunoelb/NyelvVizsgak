CREATE TABLE nyelvek (
  id int PRIMARY KEY,
  nyelv varchar(7) NOT NULL
);

CREATE TABLE vizsgak (
  sorsz int PRIMARY KEY,
  idopont datetime NOT NULL,
  nyelvid int NOT NULL FOREIGN KEY REFERENCES nyelvek(id),
  szint varchar(2) NOT NULL
);

CREATE TABLE jelentkezesek (
  sorsz int PRIMARY KEY,
  nev varchar(18) NOT NULL,
  mobil varchar(8) NOT NULL,
  szulev int nOT NULL,
  vizsga int FOREIGN KEY REFERENCES vizsgak(sorsz)
);


