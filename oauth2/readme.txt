What is a token
===============

Access token is piece of data which is created by server, and used to identify the certain user of given application, and it is used to access particular resource on the server.

Bearer Token Type
=================

The access token type provides the client with the information required to successfully utilize the access token to make a protected resource request (along with type-specific attributes). The client MUST NOT use an access token if it does not understand the token type. In this example we are using token of type "Bearer" A certain type of token, with the property that anyone can use the token, and it is commonly used. Bearer can be simply understood as "give access to the Bearer of this token." It is recommended to use Bearer token over https, with short expiration time.

Why token based authentication instead of cookie based
======================================================

Cookies:

    - Sent with every request
    - Usually supported in browsers
    - Difficult to use cross domain
    - Prone to CSRF

Token:

    - Can be used by hetrogneous clients (browsers, native mobile app etc.)
    - Work cross domain
    - Scalable (no overhead in using web farm when new server is added)
    - Offer more control
    - Loosly Coupled