<script>
    $(document).ready(function() {
        $(".star").click(function () {
            var ratingValue = $(this).data("rating");
            var itemId = /* Get the item's ID somehow, e.g., from the page URL or a data attribute */;

            $.post("/Items/SubmitRating", { itemId: itemId, ratingValue: ratingValue }, function (response) {
                if (response.success) {
                    alert("Thank you for rating!");
                }
            });
        });
    });
</script>
