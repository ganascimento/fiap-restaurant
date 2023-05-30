create database if not exists challenge_db;

use challenge_db;

drop table if exists challenge_db.tb_WeatherForecast;

create table challenge_db.tb_WeatherForecast
(
    id varchar(36) not null,
    TemperatureC integer null,
    TemperatureF integer null,
    Summary varchar(36) null,
    Date datetime default null,
    primary key (id)
);

create table challenge_db.tb_Cliente
(
    id varchar(36) not null,
    Nome varchar(200) null,
    CPF varchar(11) null,    
    primary key (id)
);

create table challenge_db.tb_Categoria
(
    id varchar(36) not null,
    Nome varchar(200) null,
    primary key (id)
);

create table challenge_db.tb_Produto
(
    id varchar(36) not null,
    Nome varchar(200) null,
    Valor decimal(19,9) null,
    primary key (id)
);


