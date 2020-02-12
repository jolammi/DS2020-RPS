import sqlalchemy as db
engine = db.create_engine(
    'mysql+mysqlconnector://a:b@localhost/ds_database',echo=True
)
connection = engine.connect()
res = connection.execute("create table user(id int, primarykey(id);)")


# CREATE TABLE Player (
#   player_id INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
#   username VARCHAR(20) NOT NULL UNIQUE,
#   ip VARCHAR(15) NOT NULL UNIQUE
# );

# CREATE TABLE Gameroom (
#   id INT NOT NULL,
#   player_id INT NOT NULL,
#   player_score INT NOT NULL DEFAULT 0,
#   INDEX player_id_idx (player_id),
#   FOREIGN KEY (player_id)
#     REFERENCES Player(id),
#   PRIMARY KEY (id, player_id)
# );
