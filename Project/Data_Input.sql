/* 
   Test data script for:
   ITEM, ITEM_INV, ITEM_INV_LINE, STORE, STORE_POS, ITEM_PKG, ITEM_CATEGORY

   Assumptions:
   - Schema from Schema.Full.SQL has been created in an empty database.
   - Identity columns start from 1.
*/

/* ------------------------------------------------------------
   0. Minimal reference data for foreign keys
   ------------------------------------------------------------ */

/* MEASUREMENT_UNIT (referenced by ITEM.MEASUREMENT_UNIT_CID) */
INSERT INTO MEASUREMENT_UNIT (CID) VALUES
(1),  -- Piece
(2),  -- Kilogram
(3),  -- Liter
(4);  -- Box

/* PACKAGE_TYPE (referenced by ITEM_PKG.PACKAGE_TYPE_CID) */
INSERT INTO PACKAGE_TYPE (CID) VALUES
(1),  -- Single unit
(2),  -- Small box
(3);  -- Pallet

/* ------------------------------------------------------------
   1. STORE
   ------------------------------------------------------------ */
INSERT INTO STORE (CID, STORE_LOC) VALUES
(1, N'Central Warehouse'),
(2, N'Downtown Store'),
(3, N'North Branch'),
(4, N'South Branch'),
(5, N'Online Fulfillment Hub'),
(6, N'East Outlet'),
(7, N'West Outlet'),
(8, N'Returns Center'),
(9, N'Clearance Store'),
(10, N'Wholesale Depot'),
(11, N'Market Kiosk A'),
(12, N'Market Kiosk B'),
(13, N'Showroom 1'),
(14, N'Showroom 2'),
(15, N'Airport Shop'),
(16, N'Station Shop'),
(17, N'Pop-up Store 1'),
(18, N'Pop-up Store 2'),
(19, N'Spare Warehouse'),
(20, N'Overflow Storage');

/* ------------------------------------------------------------
   2. STORE_POS
   ------------------------------------------------------------ */
/* 20 positions distributed across stores 1–5 */
INSERT INTO STORE_POS (CID, STORE_CID) VALUES
(1, 1),
(2, 1),
(3, 1),
(4, 2),
(5, 2),
(6, 2),
(7, 3),
(8, 3),
(9, 4),
(10, 4),
(11, 4),
(12, 5),
(13, 5),
(14, 5),
(15, 1),
(16, 2),
(17, 3),
(18, 4),
(19, 5),
(20, 1);
INSERT INTO STORE_POS (CID, STORE_CID)
VALUES
(21, 6),
(22, 6),
(23, 6),
(24, 6),
(25, 6),
(26, 7),
(27, 7),
(28, 7),
(29, 7),
(30, 7),
(31, 8),
(32, 8),
(33, 8),
(34, 8),
(35, 8),
(36, 9),
(37, 9),
(38, 9),
(39, 9),
(40, 9),
(41, 10),
(42, 10),
(43, 10),
(44, 10),
(45, 10),
(46, 11),
(47, 11),
(48, 11),
(49, 11),
(50, 11),
(51, 12),
(52, 12),
(53, 12),
(54, 12),
(55, 12),
(56, 13),
(57, 13),
(58, 13),
(59, 13),
(60, 13),
(61, 14),
(62, 14),
(63, 14),
(64, 14),
(65, 14),
(66, 15),
(67, 15),
(68, 15),
(69, 15),
(70, 15),
(71, 16),
(72, 16),
(73, 16),
(74, 16),
(75, 16),
(76, 17),
(77, 17),
(78, 17),
(79, 17),
(80, 17),
(81, 18),
(82, 18),
(83, 18),
(84, 18),
(85, 18),
(86, 19),
(87, 19),
(88, 19),
(89, 19),
(90, 19),
(91, 20),
(92, 20),
(93, 20),
(94, 20),
(95, 20);


/* ------------------------------------------------------------
   3. ITEM_CATEGORY (20 rows, hierarchical)
   ------------------------------------------------------------ */
/* Top-level categories (LEVEL = 0, no parent) */
INSERT INTO ITEM_CATEGORY (CID, LEVEL, PARENT_CATEGORY_CID) VALUES
(1, 0, NULL),  -- Electronics
(2, 0, NULL),  -- Groceries
(3, 0, NULL),  -- Household
(4, 0, NULL),  -- Clothing
(5, 0, NULL);  -- Office Supplies

/* Subcategories (LEVEL = 1, with parent) */
INSERT INTO ITEM_CATEGORY (CID, LEVEL, PARENT_CATEGORY_CID) VALUES
(6, 1, 1),   -- Mobile Phones
(7, 1, 1),   -- Laptops
(8, 1, 1),   -- Accessories
(9, 1, 2),   -- Beverages
(10, 1, 2),  -- Snacks
(11, 1, 2),  -- Canned Food
(12, 1, 3),  -- Cleaning Products
(13, 1, 3),  -- Kitchenware
(14, 1, 4),  -- Men Clothing
(15, 1, 4),  -- Women Clothing
(16, 1, 4),  -- Children Clothing
(17, 1, 5),  -- Paper Products
(18, 1, 5),  -- Writing Instruments
(19, 1, 5),  -- Storage
(20, 1, 3);  -- Bathroom Supplies

/* ------------------------------------------------------------
   4. ITEM (20 rows)
   ID is IDENTITY, assumed to start at 1.
   ------------------------------------------------------------ */
INSERT INTO ITEM (CODE, DESCRIPTION, MEASUREMENT_UNIT_CID, ITEM_CATEGORY_CID, BASE_PRICE) VALUES
(N'ITM0001', N'Smartphone Basic 32GB',              1, 6, 199.99),
(N'ITM0002', N'Smartphone Plus 64GB',               1, 6, 299.99),
(N'ITM0003', N'Laptop 14" Entry Model',             1, 7, 499.50),
(N'ITM0004', N'Laptop 15" Performance',             1, 7, 899.00),
(N'ITM0005', N'USB-C Charging Cable 1m',            1, 8,  9.90),
(N'ITM0006', N'Wireless Mouse',                     1, 8, 19.90),
(N'ITM0007', N'Sparkling Water 500ml',              3, 9,  0.60),
(N'ITM0008', N'Orange Juice 1L',                    3, 9,  1.80),
(N'ITM0009', N'Potato Chips 150g',                  2,10,  1.20),
(N'ITM0010', N'Chocolate Bar 80g',                  2,10,  1.00),
(N'ITM0011', N'Canned Tomatoes 400g',               2,11,  1.10),
(N'ITM0012', N'Floor Cleaner 1L',                   3,12,  3.50),
(N'ITM0013', N'Kitchen Sponge 5-pack',              1,13,  2.20),
(N'ITM0014', N'Mens T-Shirt Size M',                1,14, 12.99),
(N'ITM0015', N'Womens Jeans Size 38',               1,15, 29.99),
(N'ITM0016', N'Child Hoodie Size 8',                1,16, 19.99),
(N'ITM0017', N'A4 Copy Paper 500 sheets',           1,17,  4.50),
(N'ITM0018', N'Blue Ballpoint Pen',                 1,18,  0.35),
(N'ITM0019', N'Plastic Storage Box 20L',            1,19,  7.80),
(N'ITM0020', N'Hand Soap Dispenser 300ml',          3,20,  2.40);

/* ------------------------------------------------------------
   5. ITEM_PKG (20 rows)
   ID is IDENTITY, assumed to match insert order 1..20.
   ------------------------------------------------------------ */
INSERT INTO ITEM_PKG (ITEM_ID, BARCODE, SERIAL_NUM, PACKAGE_TYPE_CID) VALUES
(1,  N'1000000000001', 1000000000001, 1),
(2,  N'1000000000002', 1000000000002, 1),
(3,  N'1000000000003', 1000000000003, 2),
(4,  N'1000000000004', 1000000000004, 2),
(5,  N'1000000000005', 1000000000005, 1),
(6,  N'1000000000006', 1000000000006, 1),
(7,  N'1000000000007', 1000000000007, 2),
(8,  N'1000000000008', 1000000000008, 2),
(9,  N'1000000000009', 1000000000009, 1),
(10, N'1000000000010', 1000000000010, 1),
(11, N'1000000000011', 1000000000011, 2),
(12, N'1000000000012', 1000000000012, 2),
(13, N'1000000000013', 1000000000013, 3),
(14, N'1000000000014', 1000000000014, 3),
(15, N'1000000000015', 1000000000015, 3),
(16, N'1000000000016', 1000000000016, 3),
(17, N'1000000000017', 1000000000017, 2),
(18, N'1000000000018', 1000000000018, 2),
(19, N'1000000000019', 1000000000019, 1),
(20, N'1000000000020', 1000000000020, 1);

/* ------------------------------------------------------------
   6. ITEM_INV (20 rows, with full names)
   ------------------------------------------------------------ */
INSERT INTO ITEM_INV (STORE_CID, STATUS, REMARKS, PERSON, INV_DATETIME) VALUES
(1, 0, N'Initial yearly count',          N'Alice Thompson',      '2025-01-05T09:00:00'),
(2, 1, N'Post-holiday adjustment',       N'Bob Williams',        '2025-01-10T10:30:00'),
(3, 0, N'Quarterly stock check',         N'Chris Anderson',      '2025-02-01T14:15:00'),
(4, 2, N'Shrinkage investigation',       N'Diana Hughes',        '2025-02-05T16:45:00'),
(5, 1, N'Online hub sync',               N'Emily Johnson',       '2025-02-10T11:00:00'),
(1, 0, N'After layout change',           N'Frank Peterson',      '2025-03-01T08:00:00'),
(2, 1, N'Promotion leftovers count',     N'Georgia Martinez',    '2025-03-05T13:30:00'),
(3, 0, N'End of month cross-check',      N'Henry Wallace',       '2025-03-31T17:10:00'),
(4, 1, N'Unexpected variance review',    N'Irene McKinley',      '2025-04-02T09:40:00'),
(5, 2, N'Year-to-date control',          N'Jack Robertson',      '2025-04-10T15:20:00'),
(1, 0, N'Random audit section A',        N'Kelly Morgan',        '2025-04-15T11:05:00'),
(2, 0, N'Random audit section B',        N'Leo Harrison',        '2025-04-16T12:25:00'),
(3, 1, N'Inventory after relocation',    N'Maria Carter',        '2025-04-20T16:00:00'),
(4, 1, N'Inventory spot check',          N'Nick Armstrong',      '2025-04-22T10:10:00'),
(5, 0, N'Inventory before sale launch',  N'Olivia Reynolds',     '2025-04-25T09:50:00'),
(1, 2, N'Returns reconciliation',        N'Paul Henderson',      '2025-04-30T13:00:00'),
(2, 1, N'Partial aisle count',           N'Queenie Barrett',     '2025-05-02T14:40:00'),
(3, 0, N'New supplier arrival check',    N'Robert Caldwell',     '2025-05-05T10:00:00'),
(4, 2, N'Correction of previous errors', N'Sophia Lawrence',     '2025-05-07T11:30:00'),
(5, 0, N'Pre-holiday quick check',       N'Thomas Mitchell',     '2025-05-10T17:55:00');

INSERT INTO ITEM_INV_LINE (
    ITEM_INV_ID, ITEM_ID, ITEM_PKG_ID, STORE_POS_CID,
    REPORTED_QTY, ACTUAL_QTY, DEFICIT_SURPLUS, REMARKS
)
VALUES
(1, 1, 1, 1, 10, 10, 0, N'OK extra check 1 for inv 1'),
(1, 6, 6, 21, 8, 7, -1, N'Minor loss extra line for inv 1'),
(1, 11, 11, 41, 12, 13, 1, N'Found extra unit for inv 1'),
(1, 16, 16, 61, 6, 6, 0, N'OK extra check 2 for inv 1'),

(2, 2, 2, 2, 10, 10, 0, N'OK extra check 1 for inv 2'),
(2, 7, 7, 22, 8, 7, -1, N'Minor loss extra line for inv 2'),
(2, 12, 12, 42, 12, 13, 1, N'Found extra unit for inv 2'),
(2, 17, 17, 62, 6, 6, 0, N'OK extra check 2 for inv 2'),

(3, 3, 3, 3, 10, 10, 0, N'OK extra check 1 for inv 3'),
(3, 8, 8, 23, 8, 7, -1, N'Minor loss extra line for inv 3'),
(3, 13, 13, 43, 12, 13, 1, N'Found extra unit for inv 3'),
(3, 18, 18, 63, 6, 6, 0, N'OK extra check 2 for inv 3'),

(4, 4, 4, 4, 10, 10, 0, N'OK extra check 1 for inv 4'),
(4, 9, 9, 24, 8, 7, -1, N'Minor loss extra line for inv 4'),
(4, 14, 14, 44, 12, 13, 1, N'Found extra unit for inv 4'),
(4, 19, 19, 64, 6, 6, 0, N'OK extra check 2 for inv 4'),

(5, 5, 5, 5, 10, 10, 0, N'OK extra check 1 for inv 5'),
(5, 10, 10, 25, 8, 7, -1, N'Minor loss extra line for inv 5'),
(5, 15, 15, 45, 12, 13, 1, N'Found extra unit for inv 5'),
(5, 20, 20, 65, 6, 6, 0, N'OK extra check 2 for inv 5'),

(6, 6, 6, 6, 10, 10, 0, N'OK extra check 1 for inv 6'),
(6, 11, 11, 26, 8, 7, -1, N'Minor loss extra line for inv 6'),
(6, 16, 16, 46, 12, 13, 1, N'Found extra unit for inv 6'),
(6, 1, 1, 66, 6, 6, 0, N'OK extra check 2 for inv 6'),

(7, 7, 7, 7, 10, 10, 0, N'OK extra check 1 for inv 7'),
(7, 12, 12, 27, 8, 7, -1, N'Minor loss extra line for inv 7'),
(7, 17, 17, 47, 12, 13, 1, N'Found extra unit for inv 7'),
(7, 2, 2, 67, 6, 6, 0, N'OK extra check 2 for inv 7'),

(8, 8, 8, 8, 10, 10, 0, N'OK extra check 1 for inv 8'),
(8, 13, 13, 28, 8, 7, -1, N'Minor loss extra line for inv 8'),
(8, 18, 18, 48, 12, 13, 1, N'Found extra unit for inv 8'),
(8, 3, 3, 68, 6, 6, 0, N'OK extra check 2 for inv 8'),

(9, 9, 9, 9, 10, 10, 0, N'OK extra check 1 for inv 9'),
(9, 14, 14, 29, 8, 7, -1, N'Minor loss extra line for inv 9'),
(9, 19, 19, 49, 12, 13, 1, N'Found extra unit for inv 9'),
(9, 4, 4, 69, 6, 6, 0, N'OK extra check 2 for inv 9'),

(10, 10, 10, 10, 10, 10, 0, N'OK extra check 1 for inv 10'),
(10, 15, 15, 30, 8, 7, -1, N'Minor loss extra line for inv 10'),
(10, 20, 20, 50, 12, 13, 1, N'Found extra unit for inv 10'),
(10, 5, 5, 70, 6, 6, 0, N'OK extra check 2 for inv 10'),

(11, 11, 11, 11, 10, 10, 0, N'OK extra check 1 for inv 11'),
(11, 16, 16, 31, 8, 7, -1, N'Minor loss extra line for inv 11'),
(11, 1, 1, 51, 12, 13, 1, N'Found extra unit for inv 11'),
(11, 6, 6, 71, 6, 6, 0, N'OK extra check 2 for inv 11'),

(12, 12, 12, 12, 10, 10, 0, N'OK extra check 1 for inv 12'),
(12, 17, 17, 32, 8, 7, -1, N'Minor loss extra line for inv 12'),
(12, 2, 2, 52, 12, 13, 1, N'Found extra unit for inv 12'),
(12, 7, 7, 72, 6, 6, 0, N'OK extra check 2 for inv 12'),

(13, 13, 13, 13, 10, 10, 0, N'OK extra check 1 for inv 13'),
(13, 18, 18, 33, 8, 7, -1, N'Minor loss extra line for inv 13'),
(13, 3, 3, 53, 12, 13, 1, N'Found extra unit for inv 13'),
(13, 8, 8, 73, 6, 6, 0, N'OK extra check 2 for inv 13'),

(14, 14, 14, 14, 10, 10, 0, N'OK extra check 1 for inv 14'),
(14, 19, 19, 34, 8, 7, -1, N'Minor loss extra line for inv 14'),
(14, 4, 4, 54, 12, 13, 1, N'Found extra unit for inv 14'),
(14, 9, 9, 74, 6, 6, 0, N'OK extra check 2 for inv 14'),

(15, 15, 15, 15, 10, 10, 0, N'OK extra check 1 for inv 15'),
(15, 20, 20, 35, 8, 7, -1, N'Minor loss extra line for inv 15'),
(15, 5, 5, 55, 12, 13, 1, N'Found extra unit for inv 15'),
(15, 10, 10, 75, 6, 6, 0, N'OK extra check 2 for inv 15'),

(16, 16, 16, 16, 10, 10, 0, N'OK extra check 1 for inv 16'),
(16, 1, 1, 36, 8, 7, -1, N'Minor loss extra line for inv 16'),
(16, 6, 6, 56, 12, 13, 1, N'Found extra unit for inv 16'),
(16, 11, 11, 76, 6, 6, 0, N'OK extra check 2 for inv 16'),

(17, 17, 17, 17, 10, 10, 0, N'OK extra check 1 for inv 17'),
(17, 2, 2, 37, 8, 7, -1, N'Minor loss extra line for inv 17'),
(17, 7, 7, 57, 12, 13, 1, N'Found extra unit for inv 17'),
(17, 12, 12, 77, 6, 6, 0, N'OK extra check 2 for inv 17'),

(18, 18, 18, 18, 10, 10, 0, N'OK extra check 1 for inv 18'),
(18, 3, 3, 38, 8, 7, -1, N'Minor loss extra line for inv 18'),
(18, 8, 8, 58, 12, 13, 1, N'Found extra unit for inv 18'),
(18, 13, 13, 78, 6, 6, 0, N'OK extra check 2 for inv 18'),

(19, 19, 19, 19, 10, 10, 0, N'OK extra check 1 for inv 19'),
(19, 4, 4, 39, 8, 7, -1, N'Minor loss extra line for inv 19'),
(19, 9, 9, 59, 12, 13, 1, N'Found extra unit for inv 19'),
(19, 14, 14, 79, 6, 6, 0, N'OK extra check 2 for inv 19'),

(20, 20, 20, 20, 10, 10, 0, N'OK extra check 1 for inv 20'),
(20, 5, 5, 40, 8, 7, -1, N'Minor loss extra line for inv 20'),
(20, 10, 10, 60, 12, 13, 1, N'Found extra unit for inv 20'),
(20, 15, 15, 80, 6, 6, 0, N'OK extra check 2 for inv 20');



/* ------------------------------------------------------------
   7. ITEM_INV_LINE (20 rows)
   ID is IDENTITY.
   - ITEM_INV_ID:   1..20 (existing above)
   - ITEM_ID:       1..20 (from ITEM insert)
   - ITEM_PKG_ID:   1..20 (from ITEM_PKG insert)
   - STORE_POS_CID: 1..20 (from STORE_POS insert)
   ------------------------------------------------------------ */

INSERT INTO ITEM_INV_LINE
    (ITEM_INV_ID, ITEM_ID, ITEM_PKG_ID, STORE_POS_CID,
     REPORTED_QTY, ACTUAL_QTY, DEFICIT_SURPLUS, REMARKS)
VALUES
(1,  1,  1,  1,  10,  9,  -1, N'One unit missing from shelf'),
(2,  2,  2,  2,  15, 15,   0, N'Counts match exactly'),
(3,  3,  3,  3,   5,  6,   1, N'Extra found in back room'),
(4,  4,  4,  4,   8,  7,  -1, N'Possible theft or damage'),
(5,  5,  5,  5,  20, 19,  -1, N'Packaging damaged, removed'),
(6,  6,  6,  6,  12, 12,   0, N'OK'),
(7,  7,  7,  7,  50, 52,   2, N'Extra box received'),
(8,  8,  8,  8,  30, 29,  -1, N'Broken bottles discarded'),
(9,  9,  9,  9,  40, 40,   0, N'OK'),
(10, 10, 10, 10, 25, 24,  -1, N'Expired item removed'),
(11, 11, 11, 11, 18, 18,   0, N'OK'),
(12, 12, 12, 12, 10, 11,   1, N'Found additional piece'),
(13, 13, 13, 13, 35, 34,  -1, N'Count mismatch, minor'),
(14, 14, 14, 14, 22, 22,   0, N'OK'),
(15, 15, 15, 15, 16, 15,  -1, N'Returned but not logged'),
(16, 16, 16, 16, 14, 15,   1, N'Corrected previous error'),
(17, 17, 17, 17, 60, 60,   0, N'OK'),
(18, 18, 18, 18, 80, 79,  -1, N'Lost pen from open box'),
(19, 19, 19, 19, 12, 13,   1, N'Extra unit on top shelf'),
(20, 20, 20, 20, 27, 27,   0, N'Final check OK');



GO
