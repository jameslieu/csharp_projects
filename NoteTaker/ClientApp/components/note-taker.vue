<template>
  <div class="container">
    <div class="row">
      <div class="col-md-12">
        <h1 class="display-4">Note taker</h1>
        <p class="lead">
          The Cornell Note-Taking System organizes ideas spatially, so it’s great for visual learners.
          The idea is to give yourself space for copying down information (Notes),
          for identifying key points (Study cues),
          and for summing up the main ideas (Summary).
        </p>
        <a v-if="noteId" href="/">
          <div class="btn btn-success mb-4">Create new note</div>
        </a>
      </div>
    </div>
    <div class="row">
      <div class="container">
        <div class="card">
          <div class="card-body">
            <div class="row">
              <div class="col-md-12">
                <p class="text-right">
                  <a class="text-right" v-if="$route.params.id" v-bind:href="'/'+ noteId">#{{ noteId }}</a>
                </p>
                <div class="form-row">
                  <div class="form-group col-md">
                    <input v-model="title" type="text" class="form-control form-control-lg" id="title" placeholder="Title">
                  </div>
                </div>
                <div class="form-row">
                  <div class="form-group col-md-2">
                    <textarea v-model="studyCues" class="form-control form-control-sm min-height-100" id="study-cues" placeholder="Study Cues"></textarea>
                  </div>
                  <div class="form-group col-md-10">
                    <textarea v-model="body" class="form-control form-control-sm min-height-100" style="height: 200px" id="notes" placeholder="Notes"></textarea>
                  </div>
                </div>
                <div class="form-group">
                  <textarea v-model="summary" class="form-control form-control-sm" id="summary" style="height: 200px" placeholder="Summary"></textarea>
                </div>
                <div class="form-group">
                  <button type="button" class="btn btn-outline-primary btn-block" @click="submit()">Save</button>
                </div>
                <div v-if="success">
                  <p class="lead">
                    Your note has been successfully saved. Use this <a v-bind:href="'/' + noteId">link</a> to access your note.
                  </p>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
  export default {
    data() {
      return {
        title: "",
        studyCues: "",
        body: "",
        summary: "",
        success: false,
        noteId: null
      }
    },

    methods: {
      async submit() {
        const data = {
          title: this.title,
          studyCues: this.studyCues,
          body: this.body,
          summary: this.summary
        }

        try {
          let response;
          if (this.noteId) {
            data.noteId = this.noteId;
            response = await this.$http.put(`/api/notes/${this.noteId}`, data);
          } else {
            response = await this.$http.post(`/api/notes`, data);
            this.noteId = response.data.noteId;
          }

          this.success = !!response.data.noteId;

        } catch (err) {
          console.log(err)
        }

      },
    },


    async created() {
      const routeId = this.$route.params.id;

      if (routeId) {
        try {
          let response = await this.$http.get(`/api/notes/${routeId}`)
          const data = response.data;

          this.noteId = data.noteId;
          this.title = data.title;
          this.studyCues = data.studyCues;
          this.body = data.body;
          this.summary = data.summary;

        } catch (err) {
          // Redirect if note doesn't exist
          location.href = '/';
        }

      }
    }
  }
</script>

<style></style>
