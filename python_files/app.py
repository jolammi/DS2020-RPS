import sqlalchemy as db
from sqlalchemy.ext.declarative import declarative_base
from sqlalchemy.orm import relationship, sessionmaker

Base = declarative_base()
engine = db.create_engine("sqlite:///DS2020-RPS.db", echo=True)

connection = engine.connect()
# metadata = db.MetaData()

print(engine.table_names())

Session = sessionmaker(bind=engine)
session = Session()


class Player(Base):
    __tablename__ = 'player'
    player_id = db.Column(db.Integer, primary_key=True)
    username = db.Column(db.String(20), nullable=False, unique=True)
    ip = db.Column(db.String(15), nullable=False, unique=True)

    gameroom = relationship("Gameroom", back_populates="player")


class Gameroom(Base):
    __tablename__ = 'gameroom'
    gameroom_id = db.Column(db.Integer, primary_key=True)
    player_id = db.Column(
        db.Integer,
        db.ForeignKey("player.player_id", ondelete="SET NULL"),
        primary_key=True,
    )
    player_score = db.Column(db.Integer, nullable=False)
    player = relationship("Player", back_populates="gameroom")


Base.metadata.create_all(bind=engine)

# matti = Player(username="mattiii", ip="192.168.255.1")

# matti = Player(username="asdsa", ip="192.168.255.2")
# matti2 = Player(username="matfhgfhtiii", ip="192.168.255.3")
# matti3 = Player(username="gjgjhgjhgj", ip="192.168.255.4")
# matti4 = Player(username="432432432gfdfd", ip="192.168.255.5")


# gr1 = Gameroom(gameroom_id=1, player_id=1, player_score=20)
# gr2 = Gameroom(gameroom_id=1, player_id=2, player_score=23)
# gr3 = Gameroom(gameroom_id=2, player_id=3, player_score=55)
# gr4 = Gameroom(gameroom_id=2, player_id=1, player_score=77)
# gr5 = Gameroom(gameroom_id=3, player_id=5, player_score=1500)

# Session = sessionmaker(bind=engine)
# session = Session()


# session.add(matti)
# session.add(matti2)
# session.add(matti3)
# session.add(matti4)
# session.add(gr1)
# session.add(gr2)
# session.add(gr3)
# session.add(gr4)
# session.add(gr5)
# session.commit()


# res = connection.execute(".tables")

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
