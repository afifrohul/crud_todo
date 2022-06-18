# crud_todo

postgreSQL query

create databasae todo
create table todo(
id serial not null,
task varchar(300) not null,
category varchar(300) not null,
description text not null,
end_date date not null,
status varchar(300) null
)