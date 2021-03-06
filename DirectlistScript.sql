USE [DirectListDB]
GO
INSERT [dbo].[AspNetUsers] ([Id], [Discriminator], [Image], [Name], [Surname], [CreatedDate], [Text], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4a88af36-c692-4965-a02a-fecba453349a', N'CustomUser', N'avataaar.jfif', N'Aytan', N'Abbas', CAST(N'2022-01-02T13:19:47.3143671' AS DateTime2), N'Nullam ultricies, velit ut varius molestie, ante metus condimentum nisi, dignissim facilisis turpis ex in libero. Sed porta ante tortor, a pulvinar mi facilisis nec. Proin finibus dolor ac convallis congue.', N'aytanabbasova@gmail.com', N'AYTANABBASOVA@GMAIL.COM', N'aytanabbasova@gmail.com', N'AYTANABBASOVA@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEFYy+NrjLcVUxIQ6X1ttZBAUZFyP8PLENHEebr/9IlkDA0YQ+LAuzzpkJWGubPzXxg==', N'VMJ4MBPKIVXGDRGF3FOWP3GW7BRNXABD', N'f0543926-c544-463f-8561-a637b20dfcc1', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Blogs] ON 

INSERT [dbo].[Blogs] ([Id], [Image], [Title], [Content], [CreatedDate], [CustomUserId]) VALUES (1, N'2e813dd1-2792-4195-be6b-b8cf31965113-202201021332SS-post-1.jpg', N'Take a Look at Hotels for All Budgets', N'Nam nisl lacus, dignissim ac tristique ut, scelerisque eu massa. Vestibulum ligula nunc, rutrum in malesuada vitae, tempus sed augue. Curabitur quis lectus quis augue dapibus facilisis. Vivamus tincidunt orci est, in vehicula nisi eleifend ut. Vestibulum sagittis varius orci vitae.

Mauris aliquet ultricies ante, non faucibus ante gravida sed. Sed ultrices pellentesque purus, vulputate volutpat ipsum hendrerit sed neque sed sapien rutrum.
In ut odio libero, at vulputate urna. Nulla tristique mi a massa convallis cursus. Nulla eu mi magna. Etiam suscipit commodo gravida. Cras suscipit, quam vitae adipiscing faucibus, risus nibh laoreet odio, a porttitor metus eros ut enim. Morbi augue velit, tempus mattis dignissim nec, porta sed risus. Donec eget magna eu lorem tristique pellentesque eget eu dui. Fusce lacinia tempor malesuada. Ut lacus sapien, placerat a ornare nec, elementum sit amet felis. Maecenas pretium lorem hendrerit eros sagittis fermentum.

Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Integer vitae ante enim. Fusce sed elit est. Suspendisse sit amet mauris in quam pretium faucibus et aliquam odio.', CAST(N'2022-01-02T13:32:21.0148094' AS DateTime2), NULL)
INSERT [dbo].[Blogs] ([Id], [Image], [Title], [Content], [CreatedDate], [CustomUserId]) VALUES (2, N'bdc1bd63-acca-4b73-9550-20ce6ed96d94-202201021332SS-post-2.jpg', N'The 50 Greatest Street Arts In London', N'Nam nisl lacus, dignissim ac tristique ut, scelerisque eu massa. Vestibulum ligula nunc, rutrum in malesuada vitae, tempus sed augue. Curabitur quis lectus quis augue dapibus facilisis. Vivamus tincidunt orci est, in vehicula nisi eleifend ut. Vestibulum sagittis varius orci vitae.

Mauris aliquet ultricies ante, non faucibus ante gravida sed. Sed ultrices pellentesque purus, vulputate volutpat ipsum hendrerit sed neque sed sapien rutrum.
In ut odio libero, at vulputate urna. Nulla tristique mi a massa convallis cursus. Nulla eu mi magna. Etiam suscipit commodo gravida. Cras suscipit, quam vitae adipiscing faucibus, risus nibh laoreet odio, a porttitor metus eros ut enim. Morbi augue velit, tempus mattis dignissim nec, porta sed risus. Donec eget magna eu lorem tristique pellentesque eget eu dui. Fusce lacinia tempor malesuada. Ut lacus sapien, placerat a ornare nec, elementum sit amet felis. Maecenas pretium lorem hendrerit eros sagittis fermentum.

Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Integer vitae ante enim. Fusce sed elit est. Suspendisse sit amet mauris in quam pretium faucibus et aliquam odio.', CAST(N'2022-01-02T13:32:55.9346803' AS DateTime2), NULL)
INSERT [dbo].[Blogs] ([Id], [Image], [Title], [Content], [CreatedDate], [CustomUserId]) VALUES (3, N'd9c3cea1-bfb3-4f63-b19c-c8bf29dbcf6f-202201021333SS-post-3.jpg', N'The Best Cofee Shops In Sydney Neighborhoods', N'Nam nisl lacus, dignissim ac tristique ut, scelerisque eu massa. Vestibulum ligula nunc, rutrum in malesuada vitae, tempus sed augue. Curabitur quis lectus quis augue dapibus facilisis. Vivamus tincidunt orci est, in vehicula nisi eleifend ut. Vestibulum sagittis varius orci vitae.

Mauris aliquet ultricies ante, non faucibus ante gravida sed. Sed ultrices pellentesque purus, vulputate volutpat ipsum hendrerit sed neque sed sapien rutrum.
In ut odio libero, at vulputate urna. Nulla tristique mi a massa convallis cursus. Nulla eu mi magna. Etiam suscipit commodo gravida. Cras suscipit, quam vitae adipiscing faucibus, risus nibh laoreet odio, a porttitor metus eros ut enim. Morbi augue velit, tempus mattis dignissim nec, porta sed risus. Donec eget magna eu lorem tristique pellentesque eget eu dui. Fusce lacinia tempor malesuada. Ut lacus sapien, placerat a ornare nec, elementum sit amet felis. Maecenas pretium lorem hendrerit eros sagittis fermentum.

Phasellus enim magna, varius et commodo ut, ultricies vitae velit. Ut nulla tellus, eleifend euismod pellentesque vel, sagittis vel justo. In libero urna, venenatis sit amet ornare non, suscipit nec risus. Sed consequat justo non mauris pretium at tempor justo sodales. Quisque tincidunt laoreet malesuada. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Integer vitae ante enim. Fusce sed elit est. Suspendisse sit amet mauris in quam pretium faucibus et aliquam odio.', CAST(N'2022-01-02T13:33:22.9119367' AS DateTime2), NULL)
SET IDENTITY_INSERT [dbo].[Blogs] OFF
GO
SET IDENTITY_INSERT [dbo].[Features] ON 

INSERT [dbo].[Features] ([Id], [Name]) VALUES (1, N'SWIMMING POOL')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (2, N'FREE WIFI INTERNET ACCESS INCLUDED')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (3, N'FREE PARKING')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (4, N'SWIMMINGPOOL OUTDOOR')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (5, N'FAMILY ROOMS')
INSERT [dbo].[Features] ([Id], [Name]) VALUES (6, N'NON SMOKING ROOMS')
SET IDENTITY_INSERT [dbo].[Features] OFF
GO
SET IDENTITY_INSERT [dbo].[Restaurants] ON 

INSERT [dbo].[Restaurants] ([Id], [Name], [StartDate], [EndDate], [Address], [About], [ReceptionPhone], [CompaintPhone], [SupportPhone], [Location], [LocationNote], [CreatedDate]) VALUES (17, N' Burger House', CAST(N'2022-01-01T11:38:00.0000000' AS DateTime2), CAST(N'2022-01-01T05:38:00.0000000' AS DateTime2), N'Flat 20, Reynolds Neck, North Hele naville, FV77 8WS', N'Lorem ipsum dolor amet consecte adipisicing elit sed eiusm tempor incididunt ut labore dolore magna aliqua enim ad minim veniam. quis nostrud exercitation ullam  Duis aute irure dolor in reprehend it in voluptate velit cillum.dolore eu fugiat nulla.', N'+123 123 456 45', N'+123 123 456 45', N'+123 123 456 45', N'dkalfmgrewo', N'Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Restaurants] ([Id], [Name], [StartDate], [EndDate], [Address], [About], [ReceptionPhone], [CompaintPhone], [SupportPhone], [Location], [LocationNote], [CreatedDate]) VALUES (18, N'Cafe City', CAST(N'2022-01-08T00:43:00.0000000' AS DateTime2), CAST(N'2022-01-08T05:43:00.0000000' AS DateTime2), N'2620Cambridge Center Natural Dam, Germany', N'Lorem ipsum dolor amet consecte adipisicing elit sed eiusm tempor incididunt ut labore dolore magna aliqua enim ad minim veniam. quis nostrud exercitation ullam  Duis aute irure dolor in reprehend it in voluptate velit cillum.dolore eu fugiat nulla.', N'+123 123 456 45', N'+123 123 456 45', N'+123 123 456 45', N'dkalfmgrewo', N'Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Restaurants] ([Id], [Name], [StartDate], [EndDate], [Address], [About], [ReceptionPhone], [CompaintPhone], [SupportPhone], [Location], [LocationNote], [CreatedDate]) VALUES (19, N'HighLevel', CAST(N'2022-01-06T03:44:00.0000000' AS DateTime2), CAST(N'2022-01-08T05:44:00.0000000' AS DateTime2), N'Flat 20, Reynolds Neck, North Hele naville, FV77 8WS', N'Lorem ipsum dolor amet consecte adipisicing elit sed eiusm tempor incididunt ut labore dolore magna aliqua enim ad minim veniam. quis nostrud exercitation ullam  Duis aute irure dolor in reprehend it in voluptate velit cillum.dolore eu fugiat nulla.', N'+123 123 456 45', N'+123 123 456 45', N'+123 123 456 45', N'dkalfmgrewo', N'Cosby sweater eu banh mi, qui irure terry richardson ex squid. Aliquip placeat salvia cillum iphone. Seitan aliquip quis cardigan american apparel, butcher voluptate nisi qui.', CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Restaurants] OFF
GO
SET IDENTITY_INSERT [dbo].[FeatureToRestaurants] ON 

INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (11, 2, 18)
INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (12, 1, 19)
INSERT [dbo].[FeatureToRestaurants] ([Id], [FeatureId], [RestaurantId]) VALUES (13, 6, 17)
SET IDENTITY_INSERT [dbo].[FeatureToRestaurants] OFF
GO
SET IDENTITY_INSERT [dbo].[Menus] ON 

INSERT [dbo].[Menus] ([Id], [Name]) VALUES (3, N'Classic Burger')
INSERT [dbo].[Menus] ([Id], [Name]) VALUES (4, N'Cheddar Burger')
INSERT [dbo].[Menus] ([Id], [Name]) VALUES (5, N'Veggie Burger')
INSERT [dbo].[Menus] ([Id], [Name]) VALUES (6, N'Chicken Burger')
SET IDENTITY_INSERT [dbo].[Menus] OFF
GO
SET IDENTITY_INSERT [dbo].[MenuToRestaurants] ON 

INSERT [dbo].[MenuToRestaurants] ([Id], [Price], [Description], [RestaurantId], [MenuId]) VALUES (14, 5.0000, N'Beef, salad, mayonnaise, spicey relish, cheese', 17, 3)
INSERT [dbo].[MenuToRestaurants] ([Id], [Price], [Description], [RestaurantId], [MenuId]) VALUES (15, 6.0000, N'Cheddar cheese, lettuce, tomato, onion, dill pickles', 17, 4)
INSERT [dbo].[MenuToRestaurants] ([Id], [Price], [Description], [RestaurantId], [MenuId]) VALUES (16, 7.0000, N'Panko crumbed and fried, grilled peppers and mushroom', 17, 5)
INSERT [dbo].[MenuToRestaurants] ([Id], [Price], [Description], [RestaurantId], [MenuId]) VALUES (17, 11.0000, N'Cheese, chicken fillet, avocado, bacon, tomatoes, basil', 17, 6)
INSERT [dbo].[MenuToRestaurants] ([Id], [Price], [Description], [RestaurantId], [MenuId]) VALUES (18, 21.0000, N'Beef, salad, mayonnaise, spicey relish, cheese', 18, 3)
INSERT [dbo].[MenuToRestaurants] ([Id], [Price], [Description], [RestaurantId], [MenuId]) VALUES (19, 23.0000, N'Cheddar cheese, lettuce, tomato, onion, dill pickles', 18, 4)
INSERT [dbo].[MenuToRestaurants] ([Id], [Price], [Description], [RestaurantId], [MenuId]) VALUES (21, 7.0000, N'Panko crumbed and fried, grilled peppers and mushroom', 18, 5)
INSERT [dbo].[MenuToRestaurants] ([Id], [Price], [Description], [RestaurantId], [MenuId]) VALUES (22, 56.0000, N'Cheese, chicken fillet, avocado, bacon, tomatoes, basil', 18, 6)
INSERT [dbo].[MenuToRestaurants] ([Id], [Price], [Description], [RestaurantId], [MenuId]) VALUES (23, 24.0000, N'Panko crumbed and fried, grilled peppers and mushroom', 19, 3)
INSERT [dbo].[MenuToRestaurants] ([Id], [Price], [Description], [RestaurantId], [MenuId]) VALUES (24, 31.0000, N'Beef, salad, mayonnaise, spicey relish, cheese', 19, 4)
INSERT [dbo].[MenuToRestaurants] ([Id], [Price], [Description], [RestaurantId], [MenuId]) VALUES (25, 25.0000, N'Cheddar cheese, lettuce, tomato, onion, dill pickles', 19, 5)
INSERT [dbo].[MenuToRestaurants] ([Id], [Price], [Description], [RestaurantId], [MenuId]) VALUES (26, 6.0000, N'Cheese, chicken fillet, avocado, bacon, tomatoes, basil', 19, 6)
SET IDENTITY_INSERT [dbo].[MenuToRestaurants] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantComments] ON 

INSERT [dbo].[RestaurantComments] ([Id], [Name], [Email], [Subject], [Content], [CreatedDate], [RestaurantId]) VALUES (1, N'aytan', N'aytan@gmail.com', N'lorem ipsum', N'asjsjjsksk', CAST(N'2022-01-08T12:36:31.9358045' AS DateTime2), 17)
INSERT [dbo].[RestaurantComments] ([Id], [Name], [Email], [Subject], [Content], [CreatedDate], [RestaurantId]) VALUES (2, N'Inci', N'abbasova@gmail.com', N'lorem ipsum', N'asjsjjsksk', CAST(N'2022-01-08T12:42:51.4327280' AS DateTime2), 17)
INSERT [dbo].[RestaurantComments] ([Id], [Name], [Email], [Subject], [Content], [CreatedDate], [RestaurantId]) VALUES (3, N'Aytan', N'aytan@gmail.com', N'lorem ipsum', N'asjsjjsksk', CAST(N'2022-01-08T16:12:05.7077765' AS DateTime2), 17)
INSERT [dbo].[RestaurantComments] ([Id], [Name], [Email], [Subject], [Content], [CreatedDate], [RestaurantId]) VALUES (4, N'aytan', N'aytan@gmail.com', N'lorem ipsum', N'asjsjjsksk', CAST(N'2022-01-08T19:44:57.0679854' AS DateTime2), 17)
SET IDENTITY_INSERT [dbo].[RestaurantComments] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantImages] ON 

INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (17, N'ee5e1699-a143-4b3c-8f04-bcf4168c566e-20220108114346-dp-2.jpg', 18)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (18, N'e1fa5e6e-b33a-4395-9860-5137d9da41e7-20220108114514-cat-img-1.jpg', 19)
INSERT [dbo].[RestaurantImages] ([Id], [Image], [RestaurantId]) VALUES (19, N'1ce16b8d-a3f4-4035-b181-d69660ee32e3-202201081219SS-cat-img-2.jpg', 17)
SET IDENTITY_INSERT [dbo].[RestaurantImages] OFF
GO
SET IDENTITY_INSERT [dbo].[RestaurantManagers] ON 

INSERT [dbo].[RestaurantManagers] ([Id], [Name], [SurName], [Phone], [Email], [WebSite], [Image], [RestaurantId]) VALUES (5, N'Lena Mayer', NULL, N' (123) 123-456', N'lena@gmail.com', N'lena@lena.com', N'1b91dd50-38f4-4ac0-81bb-31c36c17f84d-202201081654SS-thumb-1.jpg', 17)
INSERT [dbo].[RestaurantManagers] ([Id], [Name], [SurName], [Phone], [Email], [WebSite], [Image], [RestaurantId]) VALUES (6, N'Victoria', N' Benson', N' (123) 123-456', N'victoria@gmail.com', N'victoria@victoria.com', N'338b7db3-15f7-4edf-910b-4f5ddc9b94bf-202201081655SS-thumb-2.jpg', 18)
INSERT [dbo].[RestaurantManagers] ([Id], [Name], [SurName], [Phone], [Email], [WebSite], [Image], [RestaurantId]) VALUES (8, N'Adel Becham', NULL, N'(123) 123-456', N'adel@gmail.com', N'adel@a.comdel', N'4d6c5f72-cafc-416d-9a3c-c38d05ef3955-202201081656SS-thumb-3.jpg', 19)
SET IDENTITY_INSERT [dbo].[RestaurantManagers] OFF
GO
SET IDENTITY_INSERT [dbo].[Tags] ON 

INSERT [dbo].[Tags] ([Id], [Name]) VALUES (1, N'DINNER')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (2, N'HOTEL')
INSERT [dbo].[Tags] ([Id], [Name]) VALUES (3, N'SEA FOOD')
SET IDENTITY_INSERT [dbo].[Tags] OFF
GO
SET IDENTITY_INSERT [dbo].[TagToRestaurants] ON 

INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (9, 3, 18)
INSERT [dbo].[TagToRestaurants] ([Id], [TagId], [RestaurantId]) VALUES (10, 1, 19)
SET IDENTITY_INSERT [dbo].[TagToRestaurants] OFF
GO
SET IDENTITY_INSERT [dbo].[BlogComments] ON 

INSERT [dbo].[BlogComments] ([Id], [Name], [Email], [Subject], [Content], [CreatedDate], [ParentBlogCommentId], [BlogId]) VALUES (1, N'Aytan', N'aytan@gmail.com', N'lorem ipsuum ', N'lorem ipsuum lorem ipsuum lorem ipsuum lorem ipsuum lorem ipsuum lorem ipsuum lorem ipsuum lorem ipsuum lorem ipsuum lorem ipsuum vvlorem ipsuum lorem ipsuum lorem ipsuum lorem ipsuum lorem ipsuum lorem ipsuum ', CAST(N'2022-01-08T16:24:10.4076470' AS DateTime2), NULL, 1)
INSERT [dbo].[BlogComments] ([Id], [Name], [Email], [Subject], [Content], [CreatedDate], [ParentBlogCommentId], [BlogId]) VALUES (2, N'Inci', N'inci@gmail.com', N'lorem ipsuum ', N'lorem ipsuum lorem ipsuum lorem ipsuum lorem ipsuum lorem ipsuum lorem ipsuum lorem ipsuum lorem ipsuum ', CAST(N'2022-01-08T16:27:26.9271993' AS DateTime2), NULL, 1)
INSERT [dbo].[BlogComments] ([Id], [Name], [Email], [Subject], [Content], [CreatedDate], [ParentBlogCommentId], [BlogId]) VALUES (3, N'Murad', N'murad@gmail.com', N'lorem ipsuum ', N'lorem ipsuum lorem ipsuum lorem ipsuum lorem ipsuum lorem ipsuum ', CAST(N'2022-01-08T16:28:37.4276320' AS DateTime2), NULL, 1)
SET IDENTITY_INSERT [dbo].[BlogComments] OFF
GO
SET IDENTITY_INSERT [dbo].[AboutProcesses] ON 

INSERT [dbo].[AboutProcesses] ([Id], [Icon], [Title], [Number], [Content]) VALUES (1, N'fa fa-bookmark', N'Plan', N'01', N'Nostrud exercitat ullamco lorem ipsum dolor sit amet, consece adipising elit, sed doeo eiusmod')
INSERT [dbo].[AboutProcesses] ([Id], [Icon], [Title], [Number], [Content]) VALUES (2, N'fa fa-rocket', N'Code', N'02', N'Nostrud exercitat ullamco lorem ipsum dolor sit amet, consece adipising elit, sed doeo eiusmod')
INSERT [dbo].[AboutProcesses] ([Id], [Icon], [Title], [Number], [Content]) VALUES (3, N'fa fa-check', N' Deliver', N'03', N'Nostrud exercitat ullamco lorem ipsum dolor sit amet, consece adipising elit, sed doeo eiusmod')
SET IDENTITY_INSERT [dbo].[AboutProcesses] OFF
GO
SET IDENTITY_INSERT [dbo].[Abouts] ON 

INSERT [dbo].[Abouts] ([Id], [Icon], [Title], [Image], [ImageText], [Content]) VALUES (1, N'fa fa-info', N'About Us', N'255ede9a-0d52-4808-ac6e-2528b6ecc7be-20220102140254-about-image.jpg', N'Lorem ipsum, dolor sit amet consectetur adipisicing elit. Vel consectetur, ipsa autem vitae quos ea laborum expedita', N'Lorem ipsum dolor sit amet consectetur adipisicing elit. Exercitationem sapiente, fugiat commodi reprehenderit expedita nam nemoMolestiae labore inventore dolor voluptatem iste voluptatum sed iusto, pariatur doloremque quo nesciunt sit!Molestiae labore inventore dolor voluptatem iste voluptatum sed iusto, pariatur doloremque quo nesciunt sit!')
SET IDENTITY_INSERT [dbo].[Abouts] OFF
GO
SET IDENTITY_INSERT [dbo].[Banners] ON 

INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (1, N'Contact Us', N'Explore your search places', N'contact Us', NULL)
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (2, N'About Us', N'Explore your search places', N'about Us', NULL)
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (3, N'Blog Listing', N'Explore your search places', N'blog Listing', NULL)
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (4, N'Blog Detail', N'Explore your search places', N'blog detail', NULL)
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (5, N'List Full Width', N'Explore your search places', N'listings', NULL)
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (6, N'List Full Width', N'Explore your search places', N'listings', NULL)
INSERT [dbo].[Banners] ([Id], [Title], [SubTitle], [Page], [Image]) VALUES (7, N'About Us', N'Explore your search places', N'about Us', N'e77a6995-b486-4147-889f-6e3d04e007d9-20220102175153-bg-cs.jpg')
SET IDENTITY_INSERT [dbo].[Banners] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([Id], [FirstName], [LastName], [Email], [Subject], [Message], [CreatedDate]) VALUES (1, N'jsjjsjsks', N'mjejfiwgjp8934t', N'aytanab@gmail.com', N'kerndiw4u235', N'q eiurh34875r', CAST(N'2022-01-02T14:43:23.0811045' AS DateTime2))
INSERT [dbo].[Contacts] ([Id], [FirstName], [LastName], [Email], [Subject], [Message], [CreatedDate]) VALUES (2, N'Aytan', N'Abbas', N'aytanab@gmail.com', N'lorem ipsum', N'lorem ipsum dolor amet', CAST(N'2022-01-02T17:13:40.6876376' AS DateTime2))
INSERT [dbo].[Contacts] ([Id], [FirstName], [LastName], [Email], [Subject], [Message], [CreatedDate]) VALUES (3, N'kmvld', N'<SDv niwer', N'aytanab@gmail.com', N'sd iufhw8rt', N'S DVkaefjvirfb', CAST(N'2022-01-02T17:40:48.5618727' AS DateTime2))
INSERT [dbo].[Contacts] ([Id], [FirstName], [LastName], [Email], [Subject], [Message], [CreatedDate]) VALUES (4, N'skfnvire', N'e,wfnviwq', N'aytanab@gmail.com', N'welkfvj', N'adf,kmvowr', CAST(N'2022-01-02T17:41:01.9413948' AS DateTime2))
INSERT [dbo].[Contacts] ([Id], [FirstName], [LastName], [Email], [Subject], [Message], [CreatedDate]) VALUES (5, N'Inci', N'Seyfullayeva', N'inci@gmail.com', N'lorem ipsum', N'lorem ipsum amet dkkdkdk', CAST(N'2022-01-03T01:37:14.4686876' AS DateTime2))
INSERT [dbo].[Contacts] ([Id], [FirstName], [LastName], [Email], [Subject], [Message], [CreatedDate]) VALUES (6, N'murad', N'abbasov', N'murad@gmail.com', N'lorem ipsum', N'sjjsjsjsjjjsjjs', CAST(N'2022-01-06T22:15:56.8264027' AS DateTime2))
INSERT [dbo].[Contacts] ([Id], [FirstName], [LastName], [Email], [Subject], [Message], [CreatedDate]) VALUES (7, N'Aytan', N'Abbasova', N'aytanab@gmail.com', N'lorem ipsum', N'kdmvALFIeiorgajeior', CAST(N'2022-01-08T19:44:45.5058315' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [Logo], [Addresss], [Addresss2], [Phone], [Phone2], [Email], [Email2], [About]) VALUES (1, N'aa0d43ec-436d-44aa-b940-847dab62c20f-20220102141818-logo-white.png', N'12345 Little Lonsdale St, Melbourne', N'423B, Road Wordwide Country, USA', N' (123) 123-456', N'+01-1234-567-8900', N'office@example.com', N'htinfotech7@gmail.com', N'Morbi convallis bibendum urna ut viverra. Maecenas quis consequat libero, a feugiat eros. Nunc ut lacinia tortor morbi ultricies laoreet ullamcorper phasellus semper.')
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET IDENTITY_INSERT [dbo].[Vacations] ON 

INSERT [dbo].[Vacations] ([Id], [Title], [Text], [Icon], [Number]) VALUES (1, N'Find Interesting Place', N'Proin dapibus nisl ornare diam varius tempus. Aenean a quam luctus, finibus tellus ut, convallis eros sollicitudin turpis.', N'fa fa-search', NULL)
INSERT [dbo].[Vacations] ([Id], [Title], [Text], [Icon], [Number]) VALUES (2, N'Contact a Few Owners', N'Maecenas pulvinar, risus in facilisis dignissim, quam nisi hendrerit nulla, id vestibulum metus nullam viverra porta purus.', N'fa fa-phone-square', NULL)
INSERT [dbo].[Vacations] ([Id], [Title], [Text], [Icon], [Number]) VALUES (3, N'Make a Reservation', N'Faucibus ante, in porttitor tellus blandit et. Phasellus tincidunt metus lectus sollicitudin feugiat pharetra consectetur.', N'fa fa-user-plus', NULL)
SET IDENTITY_INSERT [dbo].[Vacations] OFF
GO
