SELECT p."Name", c."Name"
FROM "Products" AS p
         LEFT JOIN "ProductsCategories" AS pc ON p."Id" = pc."ProductId"
         LEFT JOIN "Categories" AS c ON pc."CategoryId" = c."Id";