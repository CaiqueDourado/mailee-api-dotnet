<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Menu.ascx.cs" Inherits="Controls_Menu" %>

<ul class="menu">
	<li class="top"><a href="#" class="top_link"><span>Home</span></a></li>
	<li class="top"><a href="<%= ResolveUrl("~/Lists/View.aspx") %>" class="top_link"><span>Lists</span></a>
		<ul class="sub">
			<li><a href="<%= ResolveUrl("~/Lists/View.aspx") %>">View Lists</a></li>			
			<li><a href="<%= ResolveUrl("~/Lists/Add.aspx") %>">Add List</a></li>
		</ul>
	</li>
    <li class="top"><a href="<%= ResolveUrl("~/Contacts/View.aspx") %>" class="top_link"><span>Contacts</span></a>
		<ul class="sub">
			<li><a href="<%= ResolveUrl("~/Contacts/View.aspx") %>">View Contacts</a></li>			
			<li><a href="<%= ResolveUrl("~/Contacts/Add.aspx") %>">Add Contact</a></li>
		</ul>
	</li>
    <li class="top"><a href="<%= ResolveUrl("~/Templates/View.aspx") %>" class="top_link"><span>Templates</span></a>
		<ul class="sub">
			<li><a href="<%= ResolveUrl("~/Templates/View.aspx") %>">View Templates</a></li>			
			<li><a href="<%= ResolveUrl("~/Templates/Add.aspx") %>">Add Templates</a></li>
		</ul>
	</li>
    <li class="top"><a href="<%= ResolveUrl("~/Messages/View.aspx") %>" class="top_link"><span>Messages</span></a>
		<ul class="sub">
			<li><a href="<%= ResolveUrl("~/Messages/View.aspx") %>">View Messages</a></li>			
			<li><a href="<%= ResolveUrl("~/Messages/Add.aspx") %>">Add Messages</a></li>
		</ul>
	</li>
    <li class="top"><a href="<%= ResolveUrl("~/Reports/View.aspx") %>" class="top_link"><span>Reports</span></a>
        <ul class="sub">
			<li><a href="<%= ResolveUrl("~/Reports/View.aspx") %>">View Reports</a></li>			
			<li><a href="<%= ResolveUrl("~/Reports/ViewAccesses.aspx") %>">View Accesses</a></li>
            <li><a href="<%= ResolveUrl("~/Reports/ViewUnsubscribes.aspx") %>">View Unsubscribes</a></li>
		</ul>
    </li>
</ul>
