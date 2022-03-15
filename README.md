# Blazor Server Authentication and Authorization

Watch Tutorial Video: https://www.youtube.com/watch?v=iq2btD9WufI&list=PLzewa6pjbr3IQEUfNiK2SROQC1NuKl6PV&index=12

Blazor Tutorial C# - Part 11 is a tutorial video which explains everything about Blazor Authentication and Authorization [Blazor Auth]. In this video, we create a custom blazor server authentication state provider.

Blazor Server apps operate over a real-time connection that's created using SignalR. Authentication in SignalR-based apps is handled when the connection is established. Authentication can be based on a cookie or some other bearer token. Blazor Server apps are configured for security in the same manner as ASP.NET Core apps.

The built-in AuthenticationStateProvider service for Blazor Server apps obtains authentication state data from ASP.NET Core's HttpContext.User. This is how authentication state integrates with existing ASP.NET Core authentication mechanisms.

AuthenticationStateProvider is the underlying service used by the Blazor AuthorizeView component and CascadingAuthenticationState component to get the authentication state.

You don't typically use AuthenticationStateProvider directly.  The main drawback to using AuthenticationStateProvider directly is that the component isn't notified automatically if the underlying authentication state data changes.

The AuthenticationStateProvider service can provide the current user's ClaimsPrincipal data

If authentication state data is required for procedural logic, such as when performing an action triggered by the user, obtain the authentication state data by defining a cascading parameter of type Task of AuthenticationState.

If user.Identity.IsAuthenticated is true, claims can be enumerated and membership in roles evaluated.

AuthorizeRouteView Class combines the behaviors of Blazor AuthorizeView and Blazor RouteView, so that it displays the page matching the specified route but only if the user is authorized to see it.

The AuthorizeView component selectively displays UI content depending on whether the user is authorized. This approach is useful when you only need to display data for the user and don't need to use the user's identity in procedural logic.

The content of Authorized and NotAuthorized tags can include arbitrary items, such as other interactive components. A default event handler for an authorized element, such as the SecureMethod method for the button (Display Greeting Button) element in the video example, can only be invoked by an authorized user.

The AuthorizeView component can be used in the NavMenu component (Shared/NavMenu.razor) to display a NavLink component (NavLink), but note that this approach only removes the list item from the rendered output. It doesn't prevent the user from navigating to the component. To prevent that, blazor authorize attribute ([Authorize]) can be used in Razor components.

The AuthorizeView component supports role-based or policy-based (blazor authorization policy). For role-based authorization [blazor authorization], use the Roles parameter authorization and for policy-based authorization, use the Policy parameter.

The [Authorize] attribute (Blazor Authorize Attribute) also supports role-based or policy-based authorization. If neither Roles nor Policy is specified, [Authorize] uses the default policy.

The Router component, in conjunction with the AuthorizeRouteView component, allows the app to specify custom content by providing Authorized, NotAuthorized & Authorizing tags.

#blazor #codingdroplets #blazorauth
