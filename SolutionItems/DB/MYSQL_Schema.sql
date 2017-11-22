﻿DROP TABLE IF EXISTS utente;
CREATE TABLE IF NOT EXISTS utente (
  ID int(11) NOT NULL AUTO_INCREMENT,
  Email varchar(50) NOT NULL DEFAULT '0',
  FirstName varchar(50) NOT NULL DEFAULT '0',
  LastName varchar(50) NOT NULL DEFAULT '0',
  Password varchar(50) NOT NULL DEFAULT '0',
  PRIMARY KEY (ID)
) ENGINE=InnoDB AUTO_INCREMENT=0 DEFAULT CHARSET=latin1;

CREATE TABLE IF NOT EXISTS profili (
  IDUtente int(11) NOT NULL,
  Biografia text,
  PlayedCovers varchar(300) DEFAULT NULL,
  PersonalSetup varchar(300) DEFAULT NULL,
  FavouriteArtists varchar(300) DEFAULT NULL,
  FavouriteGenres varchar(300) DEFAULT NULL,
  ProfileImage text,
  PRIMARY KEY (IDUtente),
  CONSTRAINT Profile_ProfileUtente_ID FOREIGN KEY (IDUtente) REFERENCES utente (ID) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;