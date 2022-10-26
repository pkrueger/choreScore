-- Active: 1666715598134@@SG-kiwi-myrtle-9554-6832-mysql-master.servers.mongodirector.com@3306@stuff

CREATE TABLE
    IF NOT EXISTS chores (
        id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
        createdAt DATETIME DEFAULT CURRENT_TIMESTAMP,
        updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
        name VARCHAR(255) NOT NULL,
        isComplete BOOLEAN NOT NULL,
        day VARCHAR(255) NOT NULL,
        priority INT NOT NULL CHECK(
            priority > 0
            AND priority < 5
        ),
        creatorId VARCHAR(255) NOT NULL,
        FOREIGN KEY(creatorId) REFERENCES accounts(id) ON DELETE CASCADE
    ) DEFAULT CHARSET utf8;