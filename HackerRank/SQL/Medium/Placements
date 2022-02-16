SELECT s.name
FROM students s
JOIN friends f
ON s.id = f.id
JOIN packages p
ON f.id = p.id
JOIN packages p2
ON f.friend_id = p2.id
WHERE p.salary < p2.salary
ORDER BY p2.salary;
