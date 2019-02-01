<template>
    <main>
      <v-content>
        <v-container fluid class="main-container">
          <iframe src="https://webglsamples.org/aquarium/aquarium.html" />
        </v-container>
      </v-content>
    </main>
</template>

<script>
const props = {
  viewModel: Object
};

export default {
  components: {},
  methods: {
    enter() {
      const command = this.viewModel.AddItem;
      if (command) command.Execute();
    }
  },
  props
};
</script>

<style>
main {
  height: 100%;
}

.main-container {
  height: calc(100% - 50px);
  overflow-y: auto;
}

iframe{
  width: 100%;
  height: 100%;
}
</style>
