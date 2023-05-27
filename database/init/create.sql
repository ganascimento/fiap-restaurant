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