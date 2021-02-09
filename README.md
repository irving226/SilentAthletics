# SilentAthletics
18 Week CAD Project. A Silent Auction Web Application for MSSA. ASP.NET
Concept Selection
Brian Irving


#### Introduction

There are many applications and websites that allow their users to buy and sell used items. Unfortunately, the prices are often non-negotiable. There are not many sites that allow the users to have an influence on the equipment that they are looking to purchase, especially when it comes to used equipment. These sites also rely heavily on shipping products, which comes with its own headaches and extra fees. Silent Athletics intends to mitigate these issues by providing a platform where users are able to bid on items that are listed for sale in their area. This ensures that the user is getting a good deal on user equipment and that they receive their items the same day.  	

#### Functionality

Silent Athletics will function as an auctioning website for users looking to make some money on old or unused sports equipment that they have lying around their house. This website will allow a user to explore the local inventory of their neighborhood and place bids on items that they find for sale. The user also has the option to list an item that they are looking to get rid of in exchange for some extra cash. The contents shown to users will be within driving distance to their location so that they can pick up the item the same day they win an auction, or the user will have the option to have the seller deliver the item for a fee. I chose the name Silent Athletics because it’s a subtle nod to the main utility that the website would provide. 

The site will have two functions, a seller and a buyer function. In order to use either of these functions, a user must register with the site for an account. The registration process will be relatively brief, only requiring a username, first and last name, date of birth, and email address. They will be prompted after their account is verified to enter their payment information and their addresses. Sellers will be able to list the items that they intend to sell. They’ll have to define the type of item, what they intend to list the starting bid as, and a general location of where the winner of the bid can pick up the item. They will also have to define how long they intend to hold the auction for, and what they would like to do in the event that the listing does not sell. The seller will have a profile that lists how many items they have for auction, how many items they have listed on the site, and a rating allowing other users to gauge their levels of trustworthiness. Buyers who have made purchases from the seller previously will be able to also leave comments if they feel the need to. 

Buyers will have specific functions they can perform using Silent Athletics. Mainly, they will be able to search their local areas for used sports merchandise. Pictures of the items will be displayed with a description created by the seller, and users will be able to scroll through the photos to further inspect the item. There will also be a place for the potential buyer to ask questions about details not specified, allowing them to interact with the seller. If they see an item that they like, they will be able to place a bid. If another user bids higher, they will receive a notification, and they can either choose to raise their bid, or forfeit the item. If they do not want to bid immediately, they will be able to save the post so that they can easily return to the item at a later time. Once they have won an auction, they’ll be given the address that the seller intends to meet them at in order to claim their item. 
	
#### Database

As far as the actual site, there will be a relational database that will store user accounts and items listed for sale on the site.
For users, database will store:
*	Username
*	Password
*	Date of Birth
*	Email address
*	Telephone number
*	Address 
*	Credit/Debit card information


For items:
*	ID number
*	Item
*	Brand
*	Owner of listing 
*	How long the item is being listed on the site
*	Starting price
*	What the item ends up selling for 
*	The purchaser of the item 

[Database Diagram](Silent%20Athletics%20Database%20Diagram.pdf) 
