**Notes**
 
 - There is no dependency injection.
    - The service layer is written to look like dependency injection is used, but I didn't take the time to figure out how to bootstrap Unity into WinForms
 - Tests aren't that thorough - just enough to demonstrate an understanding of unit testing concepts
 - The repository tests aren't true unit tests.  They actually go out and read data from Azure storage tables and queues
	 - These tests are tagged with the "Integration" TestCategory

**How to make more efficient**

 - The immediate thing that came to mind as to how to make the process more efficient would be to receive the updates as some kind of a 'push'.  The storage queue api only supports actively pulling messages off of the queue, but there is no way of passively receiving a notification when a new message was added.  Doing this would allow you to model the queue as an `IObservable<ProductUpdate>` and you could drive your business logic by observing events on that.  I'm not sure if the Azure StorageBus would provide this functionality, but if so I would consider switching to that.
 - This is more of a UX comment than about efficency, but it would be nice if the data in the update queue contained information about what data changed on the product (new price, old price, etc.)  Then we could highlight the changed data in the application.  In a real project I would be asking the PO if that is something that is important to the users.
